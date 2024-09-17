namespace Graph_Winform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.dataFetchTimer = new System.Windows.Forms.Timer(this.components);
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Group_TabMenu_GraphSetting_Arduino = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.Tab_GraphSetting_Air_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Btn_Air_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Air_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Text_Air_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.n_Input_Air_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Air_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Tab_GraphSetting_Press_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Btn_Pressure_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Pressure_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Text_Pressure_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.n_Input_Pressure_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Pressure_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Tab_GraphSetting_Humid_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Btn_Humidity_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Humidity_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Text_Humidity_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.n_Input_Humidity_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Humidity_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Tab_GraphSetting_Temp_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Btn_Temperature_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Temperature_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Text_Temperature_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.n_Input_Temperature_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Temperature_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Group_Header = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.Group_Graph = new Krypton.Toolkit.KryptonTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_TabMenu_GraphSetting_Arduino)).BeginInit();
            this.Group_TabMenu_GraphSetting_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Air_Arduino)).BeginInit();
            this.Tab_GraphSetting_Air_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Press_Arduino)).BeginInit();
            this.Tab_GraphSetting_Press_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Humid_Arduino)).BeginInit();
            this.Tab_GraphSetting_Humid_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Temp_Arduino)).BeginInit();
            this.Tab_GraphSetting_Temp_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.Group_Graph.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPalette1.ControlStyles.ControlClient.StateCommon.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonPalette1.ControlStyles.ControlClient.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold);
            this.kryptonPalette1.Navigator.StateCommon.Bar.BarPaddingInside = new System.Windows.Forms.Padding(3);
            this.kryptonPalette1.Navigator.StateCommon.Bar.BarPaddingOutside = new System.Windows.Forms.Padding(1);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kryptonPalette1;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // chart5
            // 
            this.chart5.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart5.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart5.Legends.Add(legend1);
            this.chart5.Location = new System.Drawing.Point(647, 439);
            this.chart5.Name = "chart5";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart5.Series.Add(series1);
            this.chart5.Series.Add(series2);
            this.chart5.Size = new System.Drawing.Size(600, 431);
            this.chart5.TabIndex = 5;
            title1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "공기";
            this.chart5.Titles.Add(title1);
            // 
            // chart3
            // 
            this.chart3.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(647, 3);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart3.Series.Add(series3);
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(600, 430);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            title2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "습도";
            this.chart3.Titles.Add(title2);
            // 
            // Group_TabMenu_GraphSetting_Arduino
            // 
            this.Group_TabMenu_GraphSetting_Arduino.AutoSize = true;
            this.Group_TabMenu_GraphSetting_Arduino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Group_TabMenu_GraphSetting_Arduino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_TabMenu_GraphSetting_Arduino.Location = new System.Drawing.Point(1253, 3);
            this.Group_TabMenu_GraphSetting_Arduino.Name = "Group_TabMenu_GraphSetting_Arduino";
            this.Group_TabMenu_GraphSetting_Arduino.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.Tab_GraphSetting_Temp_Arduino,
            this.Tab_GraphSetting_Humid_Arduino,
            this.Tab_GraphSetting_Press_Arduino,
            this.Tab_GraphSetting_Air_Arduino});
            this.Group_TabMenu_GraphSetting_Arduino.SelectedIndex = 0;
            this.Group_TabMenu_GraphSetting_Arduino.Size = new System.Drawing.Size(333, 430);
            this.Group_TabMenu_GraphSetting_Arduino.TabIndex = 0;
            this.Group_TabMenu_GraphSetting_Arduino.Text = "kryptonDockableNavigator1";
            // 
            // Tab_GraphSetting_Air_Arduino
            // 
            this.Tab_GraphSetting_Air_Arduino.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_GraphSetting_Air_Arduino.Controls.Add(this.n_Input_Air_LowerLimit);
            this.Tab_GraphSetting_Air_Arduino.Controls.Add(this.n_Input_Air_UpperLimit);
            this.Tab_GraphSetting_Air_Arduino.Controls.Add(this.Text_Air_Tab);
            this.Tab_GraphSetting_Air_Arduino.Controls.Add(this.Btn_Air_LowerLimit);
            this.Tab_GraphSetting_Air_Arduino.Controls.Add(this.Btn_Air_UpperLimit);
            this.Tab_GraphSetting_Air_Arduino.Flags = 65534;
            this.Tab_GraphSetting_Air_Arduino.LastVisibleSet = true;
            this.Tab_GraphSetting_Air_Arduino.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_GraphSetting_Air_Arduino.Name = "Tab_GraphSetting_Air_Arduino";
            this.Tab_GraphSetting_Air_Arduino.Size = new System.Drawing.Size(213, 184);
            this.Tab_GraphSetting_Air_Arduino.Text = "공기";
            this.Tab_GraphSetting_Air_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Air_Arduino.UniqueName = "6B6409135F0E43B1DF8EE5EED13F476E";
            // 
            // Btn_Air_UpperLimit
            // 
            this.Btn_Air_UpperLimit.Location = new System.Drawing.Point(66, 76);
            this.Btn_Air_UpperLimit.Name = "Btn_Air_UpperLimit";
            this.Btn_Air_UpperLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Air_UpperLimit.TabIndex = 0;
            this.Btn_Air_UpperLimit.Values.Text = "kryptonButton1";
            // 
            // Btn_Air_LowerLimit
            // 
            this.Btn_Air_LowerLimit.Location = new System.Drawing.Point(66, 127);
            this.Btn_Air_LowerLimit.Name = "Btn_Air_LowerLimit";
            this.Btn_Air_LowerLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Air_LowerLimit.TabIndex = 1;
            this.Btn_Air_LowerLimit.Values.Text = "kryptonButton2";
            // 
            // Text_Air_Tab
            // 
            this.Text_Air_Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Text_Air_Tab.Location = new System.Drawing.Point(0, 0);
            this.Text_Air_Tab.Name = "Text_Air_Tab";
            this.Text_Air_Tab.Size = new System.Drawing.Size(213, 42);
            this.Text_Air_Tab.TabIndex = 2;
            this.Text_Air_Tab.Values.Text = "공기";
            // 
            // n_Input_Air_UpperLimit
            // 
            this.n_Input_Air_UpperLimit.Location = new System.Drawing.Point(131, 76);
            this.n_Input_Air_UpperLimit.Name = "n_Input_Air_UpperLimit";
            this.n_Input_Air_UpperLimit.Size = new System.Drawing.Size(120, 22);
            this.n_Input_Air_UpperLimit.TabIndex = 3;
            // 
            // n_Input_Air_LowerLimit
            // 
            this.n_Input_Air_LowerLimit.Location = new System.Drawing.Point(131, 127);
            this.n_Input_Air_LowerLimit.Name = "n_Input_Air_LowerLimit";
            this.n_Input_Air_LowerLimit.Size = new System.Drawing.Size(120, 22);
            this.n_Input_Air_LowerLimit.TabIndex = 4;
            // 
            // Tab_GraphSetting_Press_Arduino
            // 
            this.Tab_GraphSetting_Press_Arduino.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_GraphSetting_Press_Arduino.Controls.Add(this.n_Input_Pressure_LowerLimit);
            this.Tab_GraphSetting_Press_Arduino.Controls.Add(this.n_Input_Pressure_UpperLimit);
            this.Tab_GraphSetting_Press_Arduino.Controls.Add(this.Text_Pressure_Tab);
            this.Tab_GraphSetting_Press_Arduino.Controls.Add(this.Btn_Pressure_LowerLimit);
            this.Tab_GraphSetting_Press_Arduino.Controls.Add(this.Btn_Pressure_UpperLimit);
            this.Tab_GraphSetting_Press_Arduino.Flags = 65534;
            this.Tab_GraphSetting_Press_Arduino.LastVisibleSet = true;
            this.Tab_GraphSetting_Press_Arduino.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_GraphSetting_Press_Arduino.Name = "Tab_GraphSetting_Press_Arduino";
            this.Tab_GraphSetting_Press_Arduino.Size = new System.Drawing.Size(213, 184);
            this.Tab_GraphSetting_Press_Arduino.Text = "압력";
            this.Tab_GraphSetting_Press_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Press_Arduino.UniqueName = "B549469EA2B34A63DDAF2ABDA1628D83";
            // 
            // Btn_Pressure_UpperLimit
            // 
            this.Btn_Pressure_UpperLimit.Location = new System.Drawing.Point(66, 76);
            this.Btn_Pressure_UpperLimit.Name = "Btn_Pressure_UpperLimit";
            this.Btn_Pressure_UpperLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Pressure_UpperLimit.TabIndex = 0;
            this.Btn_Pressure_UpperLimit.Values.Text = "kryptonButton1";
            // 
            // Btn_Pressure_LowerLimit
            // 
            this.Btn_Pressure_LowerLimit.Location = new System.Drawing.Point(66, 127);
            this.Btn_Pressure_LowerLimit.Name = "Btn_Pressure_LowerLimit";
            this.Btn_Pressure_LowerLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Pressure_LowerLimit.TabIndex = 1;
            this.Btn_Pressure_LowerLimit.Values.Text = "kryptonButton2";
            // 
            // Text_Pressure_Tab
            // 
            this.Text_Pressure_Tab.Location = new System.Drawing.Point(14, 12);
            this.Text_Pressure_Tab.Name = "Text_Pressure_Tab";
            this.Text_Pressure_Tab.Size = new System.Drawing.Size(71, 42);
            this.Text_Pressure_Tab.TabIndex = 2;
            this.Text_Pressure_Tab.Values.Text = "압력";
            // 
            // n_Input_Pressure_UpperLimit
            // 
            this.n_Input_Pressure_UpperLimit.Location = new System.Drawing.Point(131, 76);
            this.n_Input_Pressure_UpperLimit.Name = "n_Input_Pressure_UpperLimit";
            this.n_Input_Pressure_UpperLimit.Size = new System.Drawing.Size(120, 22);
            this.n_Input_Pressure_UpperLimit.TabIndex = 3;
            // 
            // n_Input_Pressure_LowerLimit
            // 
            this.n_Input_Pressure_LowerLimit.Location = new System.Drawing.Point(131, 127);
            this.n_Input_Pressure_LowerLimit.Name = "n_Input_Pressure_LowerLimit";
            this.n_Input_Pressure_LowerLimit.Size = new System.Drawing.Size(120, 22);
            this.n_Input_Pressure_LowerLimit.TabIndex = 4;
            // 
            // Tab_GraphSetting_Humid_Arduino
            // 
            this.Tab_GraphSetting_Humid_Arduino.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_GraphSetting_Humid_Arduino.Controls.Add(this.n_Input_Humidity_LowerLimit);
            this.Tab_GraphSetting_Humid_Arduino.Controls.Add(this.n_Input_Humidity_UpperLimit);
            this.Tab_GraphSetting_Humid_Arduino.Controls.Add(this.Text_Humidity_Tab);
            this.Tab_GraphSetting_Humid_Arduino.Controls.Add(this.Btn_Humidity_LowerLimit);
            this.Tab_GraphSetting_Humid_Arduino.Controls.Add(this.Btn_Humidity_UpperLimit);
            this.Tab_GraphSetting_Humid_Arduino.Flags = 65534;
            this.Tab_GraphSetting_Humid_Arduino.LastVisibleSet = true;
            this.Tab_GraphSetting_Humid_Arduino.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_GraphSetting_Humid_Arduino.Name = "Tab_GraphSetting_Humid_Arduino";
            this.Tab_GraphSetting_Humid_Arduino.Size = new System.Drawing.Size(213, 184);
            this.Tab_GraphSetting_Humid_Arduino.Text = "습도";
            this.Tab_GraphSetting_Humid_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Humid_Arduino.UniqueName = "3F14DB7918304D5A1EA6C9368B319608";
            // 
            // Btn_Humidity_UpperLimit
            // 
            this.Btn_Humidity_UpperLimit.Location = new System.Drawing.Point(66, 76);
            this.Btn_Humidity_UpperLimit.Name = "Btn_Humidity_UpperLimit";
            this.Btn_Humidity_UpperLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Humidity_UpperLimit.TabIndex = 0;
            this.Btn_Humidity_UpperLimit.Values.Text = "kryptonButton1";
            // 
            // Btn_Humidity_LowerLimit
            // 
            this.Btn_Humidity_LowerLimit.Location = new System.Drawing.Point(66, 127);
            this.Btn_Humidity_LowerLimit.Name = "Btn_Humidity_LowerLimit";
            this.Btn_Humidity_LowerLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Humidity_LowerLimit.TabIndex = 1;
            this.Btn_Humidity_LowerLimit.Values.Text = "kryptonButton2";
            // 
            // Text_Humidity_Tab
            // 
            this.Text_Humidity_Tab.Location = new System.Drawing.Point(14, 12);
            this.Text_Humidity_Tab.Name = "Text_Humidity_Tab";
            this.Text_Humidity_Tab.Size = new System.Drawing.Size(71, 42);
            this.Text_Humidity_Tab.TabIndex = 2;
            this.Text_Humidity_Tab.Values.Text = "습도";
            // 
            // n_Input_Humidity_UpperLimit
            // 
            this.n_Input_Humidity_UpperLimit.Location = new System.Drawing.Point(131, 76);
            this.n_Input_Humidity_UpperLimit.Name = "n_Input_Humidity_UpperLimit";
            this.n_Input_Humidity_UpperLimit.Size = new System.Drawing.Size(120, 22);
            this.n_Input_Humidity_UpperLimit.TabIndex = 3;
            // 
            // n_Input_Humidity_LowerLimit
            // 
            this.n_Input_Humidity_LowerLimit.Location = new System.Drawing.Point(131, 127);
            this.n_Input_Humidity_LowerLimit.Name = "n_Input_Humidity_LowerLimit";
            this.n_Input_Humidity_LowerLimit.Size = new System.Drawing.Size(120, 22);
            this.n_Input_Humidity_LowerLimit.TabIndex = 4;
            // 
            // Tab_GraphSetting_Temp_Arduino
            // 
            this.Tab_GraphSetting_Temp_Arduino.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_GraphSetting_Temp_Arduino.Controls.Add(this.n_Input_Temperature_LowerLimit);
            this.Tab_GraphSetting_Temp_Arduino.Controls.Add(this.n_Input_Temperature_UpperLimit);
            this.Tab_GraphSetting_Temp_Arduino.Controls.Add(this.Text_Temperature_Tab);
            this.Tab_GraphSetting_Temp_Arduino.Controls.Add(this.Btn_Temperature_LowerLimit);
            this.Tab_GraphSetting_Temp_Arduino.Controls.Add(this.Btn_Temperature_UpperLimit);
            this.Tab_GraphSetting_Temp_Arduino.Flags = 65534;
            this.Tab_GraphSetting_Temp_Arduino.LastVisibleSet = true;
            this.Tab_GraphSetting_Temp_Arduino.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_GraphSetting_Temp_Arduino.Name = "Tab_GraphSetting_Temp_Arduino";
            this.Tab_GraphSetting_Temp_Arduino.Size = new System.Drawing.Size(331, 403);
            this.Tab_GraphSetting_Temp_Arduino.Text = "온도";
            this.Tab_GraphSetting_Temp_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Temp_Arduino.UniqueName = "0AC34B92DA9B49187389AF6E6D92DCAB";
            // 
            // Btn_Temperature_UpperLimit
            // 
            this.Btn_Temperature_UpperLimit.Location = new System.Drawing.Point(66, 76);
            this.Btn_Temperature_UpperLimit.Name = "Btn_Temperature_UpperLimit";
            this.Btn_Temperature_UpperLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Temperature_UpperLimit.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Temperature_UpperLimit.StateCommon.Back.Image")));
            this.Btn_Temperature_UpperLimit.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.Btn_Temperature_UpperLimit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Btn_Temperature_UpperLimit.TabIndex = 0;
            this.Btn_Temperature_UpperLimit.Values.Text = "";
            // 
            // Btn_Temperature_LowerLimit
            // 
            this.Btn_Temperature_LowerLimit.Location = new System.Drawing.Point(66, 127);
            this.Btn_Temperature_LowerLimit.Name = "Btn_Temperature_LowerLimit";
            this.Btn_Temperature_LowerLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Temperature_LowerLimit.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Temperature_LowerLimit.StateCommon.Back.Image")));
            this.Btn_Temperature_LowerLimit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Btn_Temperature_LowerLimit.TabIndex = 1;
            this.Btn_Temperature_LowerLimit.Values.Text = "";
            // 
            // Text_Temperature_Tab
            // 
            this.Text_Temperature_Tab.Location = new System.Drawing.Point(14, 12);
            this.Text_Temperature_Tab.Name = "Text_Temperature_Tab";
            this.Text_Temperature_Tab.Size = new System.Drawing.Size(71, 42);
            this.Text_Temperature_Tab.TabIndex = 2;
            this.Text_Temperature_Tab.Values.Text = "온도";
            // 
            // n_Input_Temperature_UpperLimit
            // 
            this.n_Input_Temperature_UpperLimit.Location = new System.Drawing.Point(131, 76);
            this.n_Input_Temperature_UpperLimit.Name = "n_Input_Temperature_UpperLimit";
            this.n_Input_Temperature_UpperLimit.Size = new System.Drawing.Size(57, 22);
            this.n_Input_Temperature_UpperLimit.TabIndex = 3;
            // 
            // n_Input_Temperature_LowerLimit
            // 
            this.n_Input_Temperature_LowerLimit.Location = new System.Drawing.Point(131, 127);
            this.n_Input_Temperature_LowerLimit.Name = "n_Input_Temperature_LowerLimit";
            this.n_Input_Temperature_LowerLimit.Size = new System.Drawing.Size(57, 22);
            this.n_Input_Temperature_LowerLimit.TabIndex = 4;
            // 
            // chart4
            // 
            this.chart4.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(3, 439);
            this.chart4.Name = "chart4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chart4.Series.Add(series5);
            this.chart4.Series.Add(series6);
            this.chart4.Size = new System.Drawing.Size(638, 431);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chart4";
            title3.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "압력";
            this.chart4.Titles.Add(title3);
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(638, 430);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            title4.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "온도";
            this.chart2.Titles.Add(title4);
            // 
            // Group_Header
            // 
            this.Group_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Group_Header.BackgroundImage")));
            this.Group_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Group_Header.ColumnCount = 2;
            this.Group_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Group_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Group_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Group_Header.Location = new System.Drawing.Point(0, 0);
            this.Group_Header.Name = "Group_Header";
            this.Group_Header.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            this.Group_Header.RowCount = 1;
            this.Group_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Group_Header.Size = new System.Drawing.Size(1589, 63);
            this.Group_Header.TabIndex = 9;
            // 
            // Group_Graph
            // 
            this.Group_Graph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Group_Graph.BackgroundImage")));
            this.Group_Graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Group_Graph.ColumnCount = 3;
            this.Group_Graph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52013F));
            this.Group_Graph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47987F));
            this.Group_Graph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.Group_Graph.Controls.Add(this.chart4, 0, 1);
            this.Group_Graph.Controls.Add(this.chart5, 1, 1);
            this.Group_Graph.Controls.Add(this.chart2, 0, 0);
            this.Group_Graph.Controls.Add(this.chart3, 1, 0);
            this.Group_Graph.Controls.Add(this.Group_TabMenu_GraphSetting_Arduino, 2, 0);
            this.Group_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Graph.Location = new System.Drawing.Point(0, 63);
            this.Group_Graph.Name = "Group_Graph";
            this.Group_Graph.RowCount = 2;
            this.Group_Graph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Group_Graph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Group_Graph.Size = new System.Drawing.Size(1589, 873);
            this.Group_Graph.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 936);
            this.Controls.Add(this.Group_Graph);
            this.Controls.Add(this.Group_Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_TabMenu_GraphSetting_Arduino)).EndInit();
            this.Group_TabMenu_GraphSetting_Arduino.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Air_Arduino)).EndInit();
            this.Tab_GraphSetting_Air_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Air_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Press_Arduino)).EndInit();
            this.Tab_GraphSetting_Press_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Press_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Humid_Arduino)).EndInit();
            this.Tab_GraphSetting_Humid_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Humid_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Temp_Arduino)).EndInit();
            this.Tab_GraphSetting_Temp_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Temp_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.Group_Graph.ResumeLayout(false);
            this.Group_Graph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer dataFetchTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator Group_TabMenu_GraphSetting_Arduino;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Temp_Arduino;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Temperature_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Temperature_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Temperature_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Temperature_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Temperature_UpperLimit;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Humid_Arduino;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Humidity_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Humidity_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Humidity_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Humidity_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Humidity_UpperLimit;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Press_Arduino;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Pressure_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Pressure_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Pressure_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Pressure_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Pressure_UpperLimit;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Air_Arduino;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Air_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Air_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Air_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Air_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Air_UpperLimit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Krypton.Toolkit.KryptonTableLayoutPanel Group_Header;
        private Krypton.Toolkit.KryptonTableLayoutPanel Group_Graph;
    }
}

