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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.Group_GraphSettings_Arduino = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Group_TabMenu_GraphSetting_Arduino = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.Tab_GraphSetting_Temp_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Tab_GraphSetting_Humid_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Tab_GraphSetting_Press_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Tab_GraphSetting_Air_Arduino = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Btn_Temperature_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Temperature_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Humidity_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Humidity_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Pressure_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Pressure_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Air_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Air_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Text_Air_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Text_Temperature_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Text_Humidity_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Text_Pressure_Tab = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.n_Input_Temperature_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Temperature_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Humidity_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Humidity_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Pressure_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Pressure_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Air_UpperLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.n_Input_Air_LowerLimit = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Group_GraphSettings_Arduino)).BeginInit();
            this.Group_GraphSettings_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Group_TabMenu_GraphSetting_Arduino)).BeginInit();
            this.Group_TabMenu_GraphSetting_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Temp_Arduino)).BeginInit();
            this.Tab_GraphSetting_Temp_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Humid_Arduino)).BeginInit();
            this.Tab_GraphSetting_Humid_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Press_Arduino)).BeginInit();
            this.Tab_GraphSetting_Press_Arduino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Air_Arduino)).BeginInit();
            this.Tab_GraphSetting_Air_Arduino.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPalette1.ControlStyles.ControlClient.StateCommon.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonPalette1.ControlStyles.ControlClient.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kryptonPalette1;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // Group_GraphSettings_Arduino
            // 
            this.Group_GraphSettings_Arduino.Controls.Add(this.Group_TabMenu_GraphSetting_Arduino);
            this.Group_GraphSettings_Arduino.Location = new System.Drawing.Point(658, 139);
            this.Group_GraphSettings_Arduino.Name = "Group_GraphSettings_Arduino";
            this.Group_GraphSettings_Arduino.Size = new System.Drawing.Size(345, 312);
            this.Group_GraphSettings_Arduino.TabIndex = 0;
            // 
            // Group_TabMenu_GraphSetting_Arduino
            // 
            this.Group_TabMenu_GraphSetting_Arduino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_TabMenu_GraphSetting_Arduino.Location = new System.Drawing.Point(0, 0);
            this.Group_TabMenu_GraphSetting_Arduino.Name = "Group_TabMenu_GraphSetting_Arduino";
            this.Group_TabMenu_GraphSetting_Arduino.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.Tab_GraphSetting_Temp_Arduino,
            this.Tab_GraphSetting_Humid_Arduino,
            this.Tab_GraphSetting_Press_Arduino,
            this.Tab_GraphSetting_Air_Arduino});
            this.Group_TabMenu_GraphSetting_Arduino.SelectedIndex = 3;
            this.Group_TabMenu_GraphSetting_Arduino.Size = new System.Drawing.Size(345, 312);
            this.Group_TabMenu_GraphSetting_Arduino.TabIndex = 0;
            this.Group_TabMenu_GraphSetting_Arduino.Text = "kryptonDockableNavigator1";
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
            this.Tab_GraphSetting_Temp_Arduino.Size = new System.Drawing.Size(343, 285);
            this.Tab_GraphSetting_Temp_Arduino.Text = "온도";
            this.Tab_GraphSetting_Temp_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Temp_Arduino.UniqueName = "0AC34B92DA9B49187389AF6E6D92DCAB";
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
            this.Tab_GraphSetting_Humid_Arduino.Size = new System.Drawing.Size(343, 285);
            this.Tab_GraphSetting_Humid_Arduino.Text = "습도";
            this.Tab_GraphSetting_Humid_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Humid_Arduino.UniqueName = "3F14DB7918304D5A1EA6C9368B319608";
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
            this.Tab_GraphSetting_Press_Arduino.Size = new System.Drawing.Size(343, 285);
            this.Tab_GraphSetting_Press_Arduino.Text = "압력";
            this.Tab_GraphSetting_Press_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Press_Arduino.UniqueName = "B549469EA2B34A63DDAF2ABDA1628D83";
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
            this.Tab_GraphSetting_Air_Arduino.Size = new System.Drawing.Size(343, 285);
            this.Tab_GraphSetting_Air_Arduino.Text = "공기";
            this.Tab_GraphSetting_Air_Arduino.ToolTipTitle = "Page ToolTip";
            this.Tab_GraphSetting_Air_Arduino.UniqueName = "6B6409135F0E43B1DF8EE5EED13F476E";
            // 
            // Btn_Temperature_UpperLimit
            // 
            this.Btn_Temperature_UpperLimit.Location = new System.Drawing.Point(66, 76);
            this.Btn_Temperature_UpperLimit.Name = "Btn_Temperature_UpperLimit";
            this.Btn_Temperature_UpperLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Temperature_UpperLimit.TabIndex = 0;
            this.Btn_Temperature_UpperLimit.Values.Text = "상한선";
            // 
            // Btn_Temperature_LowerLimit
            // 
            this.Btn_Temperature_LowerLimit.Location = new System.Drawing.Point(66, 127);
            this.Btn_Temperature_LowerLimit.Name = "Btn_Temperature_LowerLimit";
            this.Btn_Temperature_LowerLimit.Size = new System.Drawing.Size(33, 33);
            this.Btn_Temperature_LowerLimit.TabIndex = 1;
            this.Btn_Temperature_LowerLimit.Values.Text = "하한선";
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
            this.Text_Air_Tab.Location = new System.Drawing.Point(14, 13);
            this.Text_Air_Tab.Name = "Text_Air_Tab";
            this.Text_Air_Tab.Size = new System.Drawing.Size(35, 20);
            this.Text_Air_Tab.TabIndex = 2;
            this.Text_Air_Tab.Values.Text = "공기";
            // 
            // Text_Temperature_Tab
            // 
            this.Text_Temperature_Tab.Location = new System.Drawing.Point(14, 12);
            this.Text_Temperature_Tab.Name = "Text_Temperature_Tab";
            this.Text_Temperature_Tab.Size = new System.Drawing.Size(35, 20);
            this.Text_Temperature_Tab.TabIndex = 2;
            this.Text_Temperature_Tab.Values.Text = "온도";
            // 
            // Text_Humidity_Tab
            // 
            this.Text_Humidity_Tab.Location = new System.Drawing.Point(14, 12);
            this.Text_Humidity_Tab.Name = "Text_Humidity_Tab";
            this.Text_Humidity_Tab.Size = new System.Drawing.Size(35, 20);
            this.Text_Humidity_Tab.TabIndex = 2;
            this.Text_Humidity_Tab.Values.Text = "습도";
            // 
            // Text_Pressure_Tab
            // 
            this.Text_Pressure_Tab.Location = new System.Drawing.Point(14, 12);
            this.Text_Pressure_Tab.Name = "Text_Pressure_Tab";
            this.Text_Pressure_Tab.Size = new System.Drawing.Size(35, 20);
            this.Text_Pressure_Tab.TabIndex = 2;
            this.Text_Pressure_Tab.Values.Text = "압력";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 620);
            this.Controls.Add(this.Group_GraphSettings_Arduino);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Group_GraphSettings_Arduino)).EndInit();
            this.Group_GraphSettings_Arduino.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Group_TabMenu_GraphSetting_Arduino)).EndInit();
            this.Group_TabMenu_GraphSetting_Arduino.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Temp_Arduino)).EndInit();
            this.Tab_GraphSetting_Temp_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Temp_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Humid_Arduino)).EndInit();
            this.Tab_GraphSetting_Humid_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Humid_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Press_Arduino)).EndInit();
            this.Tab_GraphSetting_Press_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Press_Arduino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GraphSetting_Air_Arduino)).EndInit();
            this.Tab_GraphSetting_Air_Arduino.ResumeLayout(false);
            this.Tab_GraphSetting_Air_Arduino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel Group_GraphSettings_Arduino;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator Group_TabMenu_GraphSetting_Arduino;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Temp_Arduino;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Humid_Arduino;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Press_Arduino;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GraphSetting_Air_Arduino;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Temperature_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Temperature_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Humidity_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Humidity_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Pressure_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Pressure_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Air_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Air_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Air_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Temperature_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Humidity_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Text_Pressure_Tab;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Temperature_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Temperature_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Humidity_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Humidity_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Pressure_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Pressure_UpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Air_LowerLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown n_Input_Air_UpperLimit;
    }
}

