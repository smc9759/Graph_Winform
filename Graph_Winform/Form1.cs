#define SIMULATION
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
        private string lastFetchedDataFile1 = string.Empty;
        private string lastFetchedDataFile2 = string.Empty;
        public Form1()
        {
            InitializeComponent();
            InitializeDataFetchTimer(); // 타이머 초기화 및 시작

            InitializeCharts_GraphTap();
            InitializeTimer_GraphTap(); // 타이머 초기화
            LoadInitialData();
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


        #region Graph
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

            // 차트 영역 추가 및 배경색 설정
            ChartArea chartArea = new ChartArea("MainArea")
            {
                BackColor = Color.Gray // 차트 영역의 배경색 설정
            };
            chart.ChartAreas.Add(chartArea);

            // 차트 전체의 배경색 설정
            chart.BackColor = Color.Gray; // 차트 자체의 배경색 설정

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
#endregion
        #region Arduino Sensor Data
        private async Task FetchDataFromBothFilesAsync()
        {
            try
            {
                // 첫 번째 파일 경로
                string dynamicDbFilePath1 = GetDynamicDbFilePath("B_001");
                // 첫 번째 파일이 존재하는지 확인
                if (!File.Exists(dynamicDbFilePath1))
                {
                }
                else
                {
                    // 첫 번째 파일에서 데이터 읽기
                    var result1 = await FetchDataFromFileAsync(dynamicDbFilePath1, lastFetchedDataFile1);
                    lastFetchedDataFile1 = result1.Item1;

                    // 데이터베이스 쿼리가 성공한 경우 업데이트 시간 갱신
                    //if (result1.Item3)
                    //{
                    //    lastUpdateTimeFile1 = DateTime.Now;
                    //}

                    //// 데이터가 30초 동안 업데이트되지 않았을 경우 라벨 업데이트
                    //if ((DateTime.Now - lastUpdateTimeFile1).TotalSeconds >= 30)
                    //{
                    //    //SetDisconnectedState(Model2_NAME1_ST, Model2_TEM1_ST, Model2_HUM1_ST, Model2_PRE1_ST, Model2_VOC1_ST, Model2_TYPE1_ST);
                    //}
                }

                // 두 번째 파일 경로
                string dynamicDbFilePath2 = GetDynamicDbFilePath("B_002");
                // 두 번째 파일이 존재하는지 확인
                if (!File.Exists(dynamicDbFilePath2))
                {
                }
                else
                {
                    // 두 번째 파일에서 데이터 읽기
                    var result2 = await FetchDataFromFileAsync(dynamicDbFilePath2, lastFetchedDataFile2);
                    lastFetchedDataFile2 = result2.Item1;

                    // 데이터베이스 쿼리가 성공한 경우 업데이트 시간 갱신
                    //if (result2.Item3)
                    //{
                    //    lastUpdateTimeFile2 = DateTime.Now;
                    //}

                    //// 데이터가 30초 동안 업데이트되지 않았을 경우 라벨 업데이트
                    //if ((DateTime.Now - lastUpdateTimeFile2).TotalSeconds >= 30)
                    //{
                    //    //SetDisconnectedState(Model2_NAME2_ST, Model2_TEM2_ST, Model2_HUM2_ST, Model2_PRE2_ST, Model2_VOC2_ST, Model2_TYPE2_ST);
                    //}
                }
            }
            catch (Exception ex)
            {
                LogMessageAsync($"Error fetching data from database: {ex}");
                //MessageBox.Show($"Error fetching data from database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<(string, DateTime, bool)> FetchDataFromFileAsync(string dbFilePath, string lastFetchedData)
        {
            DateTime lastUpdateTime = DateTime.MinValue;
            bool isSuccess = false; // 데이터 읽기 성공 여부

            try
            {
                string connectionString = $"Data Source={dbFilePath};Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // 데이터 조회 쿼리 (마지막 행의 각 컬럼을 가져옴)
                    //string query = "SELECT Device_name, Temperature, Humidity, Pressure, Gas, Type FROM data_table ORDER BY Time DESC LIMIT 1";
                    string query = "SELECT Device_name, Temperature, Humidity, Pressure, Gas, Type, Time FROM data_table ORDER BY Time DESC LIMIT 1";


                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = (SQLiteDataReader)await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                // 각 컬럼 데이터를 읽어옴
                                var deviceName = reader["Device_name"].ToString();
                                var temperature = reader["Temperature"].ToString();
                                var humidity = reader["Humidity"].ToString();
                                var pressure = reader["Pressure"].ToString();
                                var gas = reader["Gas"].ToString();
                                var type = reader["Type"].ToString();
                                //var B_TimeData = reader["Time"].ToString() ;

                                // Time 데이터를 DateTime으로 변환 (형식: "yyyy-MM-dd_HH:mm:ss")
                                string timeString = reader["Time"].ToString(); // Time 컬럼을 문자열로 가져옴
                                DateTime dataTime = DateTime.ParseExact(timeString, "yyyy-MM-dd_HH:mm:ss", null); // Time을 DateTime으로 변환

                                // 새로운 데이터 행을 하나의 문자열로 결합하여 비교용 데이터 생성
                                string currentFetchedData = $"{deviceName}{temperature}{humidity}{pressure}{gas}{type}{timeString}";


                                // 새로운 데이터 행을 하나의 문자열로 결합하여 비교용 데이터 생성
                                //string currentFetchedData = $"{deviceName}{temperature}{humidity}{pressure}{gas}{type}{dataTime}";

                                // 이전 데이터와 현재 데이터를 비교
                                if (currentFetchedData != lastFetchedData)
                                {
                                    // 새로운 데이터로 업데이트
                                    lastFetchedData = currentFetchedData;
                                    lastUpdateTime = DateTime.Now; // 마지막 업데이트 시간 갱신
                                    isSuccess = true; // 데이터가 성공적으로 읽혔고 업데이트됨

                                }
                                else
                                {
                                    // 데이터는 성공적으로 읽혔으나 값이 동일함
                                    isSuccess = true;


                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessageAsync($"Error fetching data from {dbFilePath}: {ex}");
                //MessageBox.Show($"Error fetching data from {dbFilePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (lastFetchedData, lastUpdateTime, isSuccess); // 최종적으로 업데이트된 lastFetchedData, lastUpdateTime, isSuccess 반환
        }

        private void SetDisconnectedState(params Label[] labels)
        {
            // "Disconnected" 상태 설정
            labels[5].Text = "Disconnected";
            for (int i = 0; i < labels.Length; i++)
            {
                if (i != 5) // labelType의 index는 5이므로 나머지 라벨에 대해서만 "-"
                    labels[i].Text = "-";
            }
        }

        private string GetDynamicDbFilePath(string suffix)
        {
            // 현재 시간 가져오기
            DateTime now = DateTime.Now;
            string year = now.Year.ToString();
            string month = now.ToString("MM"); // 두 자리 월 형식
            string day = now.ToString("dd");   // 두 자리 일 형식

            // 동적 경로 생성
            string folderPath = Path.Combine(Variable.baseFolderPath, $"B_{year}", $"B_{year}{month}", $"B_{year}{month}{day}");
            string dbFileName = $"SVMU_{year}{month}{day}_{suffix}.db"; // 실제 사용 중인 DB 파일 이름으로 수정

            // 최종 데이터베이스 파일 경로
            string dynamicDbFilePath = Path.Combine(folderPath, dbFileName);

            return dynamicDbFilePath;
        }
        private void InitializeDataFetchTimer()
        {
            dataFetchTimer.Interval = 1000; // 1초마다 실행
            dataFetchTimer.Tick += async (sender, e) => await FetchDataFromBothFilesAsync(); // 비동기 데이터 읽기
            dataFetchTimer.Start();
        }
        #endregion

        #region GraphSetting

        private void UpdateChart(Chart chart, int yValue, string seriesName, Color color)
        {
            // Remove existing series with the specified name
            var existingSeries = chart.Series.FindByName(seriesName);
            if (existingSeries != null)
            {
                chart.Series.Remove(existingSeries);
            }

            // Create or get the series for the line
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line, // Ensure line chart type
                Color = color,
                BorderWidth = 2 // Set width to make line visible
            };
            chart.Series.Add(series);

            // Get the chart area
            var chartArea = chart.ChartAreas[0];
            if (chartArea == null)
            {
                return;
            }

            // Get the minimum and maximum DateTime values of the X-axis
            DateTime xMin = DateTime.Now.AddHours(-48);
            DateTime xMax = DateTime.Now;

            // Clear existing points
            series.Points.Clear();

            // Add points to span the entire width of the chart
            series.Points.AddXY(xMin, yValue);
            series.Points.AddXY(xMax, yValue);
        }

        private void ChartButton(Chart chart, Krypton.Ribbon.KryptonRibbonGroupNumericUpDown input, string seriesName, Color color)
        {
            int n_Value = (int)input.Value;
            UpdateChart(chart, n_Value, seriesName, color);
        }

        private void Btn_Temperature_UpperLimit_Click(object sender, EventArgs e) => ChartButton(chart2, n_Input_Temperature_UpperLimit, "MIN", Color.Red);
        private void Btn_Temperature_LowerLimit_Click(object sender, EventArgs e) => ChartButton(chart2, n_Input_Temperature_LowerLimit, "MAX", Color.Blue);
        private void Btn_Humidity_UpperLimit_Click(object sender, EventArgs e) => ChartButton(chart3, n_Input_Humidity_UpperLimit, "MIN", Color.Red);
        private void Btn_Humidity_LowerLimit_Click(object sender, EventArgs e) => ChartButton(chart3, n_Input_Humidity_LowerLimit, "MAX", Color.Blue);
        private void Btn_Pressure_UpperLimit_Click(object sender, EventArgs e) => ChartButton(chart4, n_Input_Pressure_UpperLimit, "MIN", Color.Red);
        private void Btn_Pressure_LowerLimit_Click(object sender, EventArgs e) => ChartButton(chart4, n_Input_Pressure_LowerLimit, "MAX", Color.Blue);
        private void Btn_Air_UpperLimit_Click(object sender, EventArgs e) => ChartButton(chart5, n_Input_Air_UpperLimit, "MIN", Color.Red);
        private void Btn_Air_LowerLimit_Click(object sender, EventArgs e) => ChartButton(chart5, n_Input_Air_LowerLimit, "MAX", Color.Blue);

        #endregion
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