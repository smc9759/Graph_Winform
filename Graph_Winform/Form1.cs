using ComponentFactory.Krypton.Toolkit;
using Graph_Winform.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_Winform
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task LogMessageAsync(string message)
        {
            try
            {
                string year = DateTime.Now.ToString("yyyy");
                string month = DateTime.Now.ToString("MM");
                string day = DateTime.Now.ToString("dd");
                string hour = DateTime.Now.ToString("HH");

                string logFileName = $"Log_{year}{month}{day}_UI.txt";
                string logDirectoryPath = Variable.LogPath;
                string fullLogFilePath = Path.Combine(logDirectoryPath, logFileName);

                if (!Directory.Exists(logDirectoryPath))
                {
                    Directory.CreateDirectory(logDirectoryPath);
                }

                using (StreamWriter writer = new StreamWriter(fullLogFilePath, append: true))
                {
                    await writer.WriteLineAsync($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
                }
            }
            catch (Exception ex)
            {
                // 파일에 로그 기록이 실패한 경우, 기본적으로 예외를 무시
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// TAP Graph 관련 표현이다.
        /// 
        private void InitializeCharts_GraphTap()
        {
            InitializeChartEach_GraphTap(chart2, "TemperatureSeries");
            InitializeChartEach_GraphTap(chart3, "HumiditySeries");
            InitializeChartEach_GraphTap(chart4, "PressureSeries");
            InitializeChartEach_GraphTap(chart5, "GasSeries");

        }

        private void InitializeChartEach_GraphTap(Chart chart, string seriesName)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear(); // 기존 범례를 삭제 후 새로운 범례를 설정


        }

        private void InitializeTimer_GraphTap()
        {
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 60000; // 60초 간격으로 타이머 설정
            updateTimer.Tick += async (sender, e) => await UpdateDataAsync(); // Tick 이벤트에 이벤트 핸들러 추가
            updateTimer.Start(); // 타이머 시작
        }



        private async Task UpdateDataAsync()
        {
            await LoadDataFromFileAsync_GraphTap();
        }

        private async void LoadInitialData()
        {
            // 폼이 로드된 직후 데이터를 불러오는 메서드
            await UpdateDataAsync(); // 첫 번째 데이터 불러오기
        }

        //Todo: B_폴더 찾는부분 없애기
        private async Task LoadDataFromFileAsync_GraphTap()
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime yesterday = today.AddDays(-1);

                string year = today.ToString("yyyy");
                string month = today.ToString("MM");
                string day = today.ToString("dd");
                string yearYesterday = yesterday.ToString("yyyy");
                string monthYesterday = yesterday.ToString("MM");
                string dayYesterday = yesterday.ToString("dd");

                string folderPath_Today = Path.Combine(Variable.baseFolderPath, $"B_{year}", $"B_{year}{month}", $"B_{year}{month}{day}");
                string folderPath_Yesterday = Path.Combine(Variable.baseFolderPath, $"B_{yearYesterday}", $"B_{yearYesterday}{monthYesterday}", $"B_{yearYesterday}{monthYesterday}{dayYesterday}");

                // B_001과 B_002의 데이터를 저장할 DataTable을 각각 생성
                DataTable dataTable_B001 = CreateDataTable();
                DataTable dataTable_B002 = CreateDataTable();
#if !SIMULATION
                // 어제의 B_001 및 B_002 데이터 로드
                if (Directory.Exists(folderPath_Yesterday))
                {
                    var filesYesterday_B001 = Directory.GetFiles(folderPath_Yesterday, $"SVMU_{yearYesterday}{monthYesterday}{dayYesterday}_B_001.db");
                    var filesYesterday_B002 = Directory.GetFiles(folderPath_Yesterday, $"SVMU_{yearYesterday}{monthYesterday}{dayYesterday}_B_002.db");

                    foreach (var dbFilePath in filesYesterday_B001)
                    {
                        await LoadAndAppendData(dbFilePath, dataTable_B001);
                    }

                    foreach (var dbFilePath in filesYesterday_B002)
                    {
                        await LoadAndAppendData(dbFilePath, dataTable_B002);
                    }
                }
                else
                {
                    LogMessageAsync($"Folder does not exist: {folderPath_Yesterday}");
                }

                // 오늘의 B_001 및 B_002 데이터 로드
                if (Directory.Exists(folderPath_Today))
                {
                    var filesToday_B001 = Directory.GetFiles(folderPath_Today, $"SVMU_{year}{month}{day}_B_001.db");
                    var filesToday_B002 = Directory.GetFiles(folderPath_Today, $"SVMU_{year}{month}{day}_B_002.db");

                    foreach (var dbFilePath in filesToday_B001)
                    {
                        await LoadAndAppendData(dbFilePath, dataTable_B001);
                    }

                    foreach (var dbFilePath in filesToday_B002)
                    {
                        await LoadAndAppendData(dbFilePath, dataTable_B002);
                    }
                }
                else
                {
                    MessageBox.Show($"Folder does not exist: {folderPath_Today}");
                }
#endif
                // 두 데이터 테이블을 각각의 차트 시리즈에 표시
                DisplayDataOnCharts(dataTable_B001, dataTable_B002);
            }
            catch (Exception ex)
            {
                LogMessageAsync($"Error loading data: {ex}");
                //MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DataTable 생성 함수
        private DataTable CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Time", typeof(DateTime));
            table.Columns.Add("Temperature", typeof(double));
            table.Columns.Add("Humidity", typeof(double));
            table.Columns.Add("Pressure", typeof(double));
            table.Columns.Add("Gas", typeof(double));
            return table;
        }

        private async Task LoadAndAppendData(string dbFilePath, DataTable dataTable)
        {
            try
            {
                if (File.Exists(dbFilePath))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
                    {
                        await conn.OpenAsync();

                        string query = "SELECT Time, Temperature, Humidity, Pressure, Gas FROM data_table WHERE Time >= @startTime";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            DateTime startTime = DateTime.Now.AddHours(-24);
                            cmd.Parameters.AddWithValue("@startTime", startTime.ToString("yyyy-MM-dd HH:mm:ss"));

                            using (var reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync())
                            {
                                while (await reader.ReadAsync())
                                {
                                    DateTime time = DateTime.ParseExact(reader["Time"].ToString(), "yyyy-MM-dd_HH:mm:ss", CultureInfo.InvariantCulture);
                                    double temperature = Convert.ToDouble(reader["Temperature"]);
                                    double humidity = Convert.ToDouble(reader["Humidity"]);
                                    double pressure = Convert.ToDouble(reader["Pressure"]);
                                    double gas = Convert.ToDouble(reader["Gas"]);

                                    dataTable.Rows.Add(time, temperature, humidity, pressure, gas);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessageAsync($"Error loading data from {dbFilePath}: {ex}");
                //MessageBox.Show($"Error loading data from {dbFilePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 두 개의 데이터 테이블을 각각 시리즈로 표시하는 함수
        void DisplayDataOnCharts(DataTable dataTable_B001, DataTable dataTable_B002)
        {
            chart2.Series.Clear();
            UpdateChart(chart2, dataTable_B001, "Temperature_B001", "Temperature", Color.Red);
            UpdateChart(chart2, dataTable_B002, "Temperature_B002", "Temperature", Color.Orange);

            chart3.Series.Clear();
            UpdateChart(chart3, dataTable_B001, "Humidity_B001", "Humidity", Color.Red);
            UpdateChart(chart3, dataTable_B002, "Humidity_B002", "Humidity", Color.Orange);

            chart4.Series.Clear();
            UpdateChart(chart4, dataTable_B001, "Pressure_B001", "Pressure", Color.Red);
            UpdateChart(chart4, dataTable_B002, "Pressure_B002", "Pressure", Color.Orange);

            chart5.Series.Clear();
            UpdateChart(chart5, dataTable_B001, "Gas_B001", "Gas", Color.Red);
            UpdateChart(chart5, dataTable_B002, "Gas_B002", "Gas", Color.Orange);
        }

        private void UpdateChart(Chart chart, DataTable dataTable, string seriesName, string dataColumnName, Color seriesColor)
        {
            // 시리즈가 이미 존재하는지 확인하고, 존재하면 삭제
            if (chart.Series.IsUniqueName(seriesName) == false)
            {
                chart.Series.Remove(chart.Series[seriesName]);
            }

            // 새로운 시리즈 추가 및 색상 설정
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line,
                Color = seriesColor // 시리즈 색상 설정
            };
            chart.Series.Add(series);

            // 데이터 추가
            // Add data points to the series
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime timeStamp = (DateTime)row["Time"];
                    double value = (double)row[dataColumnName];

                    series.Points.AddXY(timeStamp, value);
                }
            }
            else
            {
                // Add a default point if no data is available
                series.Points.AddXY(DateTime.Now, 0);
            }


            // 축 설정
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "yyMMdd HH";
            chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            chart.ChartAreas[0].AxisX.Interval = 6; // 6시간 간격
        }
    }
}

#region Comments

/*           CHART DARKMODE
 *             // 차트 영역 추가 및 배경색 설정
            ChartArea chartArea = new ChartArea("MainArea")
            {
                BackColor = Color.FromArgb(32, 41, 59) // 차트 영역의 배경색 설정
            };
            chart.ChartAreas.Add(chartArea);

            // 선 그래프타입으로 설정
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line
            };
            chart.Series.Add(series);

            // 차트 전체의 배경색 설정
            chart.BackColor = Color.FromArgb(32, 41, 59); // 차트 자체의 배경색 설정

            // X축 및 Y축 설정 (라인과 글자 색상 하얀색으로 설정)
            chartArea.AxisX.LabelStyle.ForeColor = Color.White; // X축 글자 색상 설정
            chartArea.AxisY.LabelStyle.ForeColor = Color.White; // Y축 글자 색상 설정
            chartArea.AxisX.LineColor = Color.White;            // X축 라인 색상 설정
            chartArea.AxisY.LineColor = Color.White;            // Y축 라인 색상 설정
            chartArea.AxisX.MajorGrid.LineColor = Color.White;  // X축 격자선 색상 설정
            chartArea.AxisY.MajorGrid.LineColor = Color.White;  // Y축 격자선 색상 설정

            // 범례 추가
            Legend legend = new Legend("MainLegend")
            {
                Docking = Docking.Top,            // 범례의 위치를 상단에 설정
                BackColor = Color.Transparent,    // 범례의 배경을 투명하게 설정
                ForeColor = Color.White           // 범례 텍스트 색상을 흰색으로 설정
            };
            chart.Legends.Add(legend);
 */

#endregion