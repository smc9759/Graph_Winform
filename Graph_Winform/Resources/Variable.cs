﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Winform.Resources 
{
    public static class Variable
    {
        public static string baseFolderPath = @"D:\DATASETS\RESULT";
        public static string LogPath = @"D:\DATASETS\LOG";

        //public static string Model1 = "Model 1 Title"; // 차트 레전드 제목
        public static double Model1_Chart_Minimum_X = 0D;
        public static double Model1_Chart_Maximum_X = Double.NaN;

        public static double Model1_Chart_Minimum_Y = 0D;
        public static double Model1_Chart_Maximum_Y = Double.NaN;

        public static string Model1_Label1_Text = "    S_001";
        public static string Model1_Label2_Text = "    S_002";
        public static string Model1_Label3_Text = "    S_003";
        public static string Model1_Label4_Text = "    S_004";
        public static string Model1_Label5_Text = "    S_005";
        public static string Model1_Label6_Text = "    S_006";

        public static string Model2_Label1_Text = "    B_001";
        public static string Model2_Label2_Text = "    B_002";




        public static string Model2_TEM1_ST_Text = "    -   ";
        public static string Model2_TEM2_ST_Text = "    -   ";
        public static string Model2_HUM1_ST_Text = "    -   ";
        public static string Model2_HUM2_ST_Text = "    -   ";
        public static string Model2_PRE1_ST_Text = "    -   ";
        public static string Model2_PRE2_ST_Text = "    -   ";
        public static string Model2_VOC1_ST_Text = "    -   ";
        public static string Model2_VOC2_ST_Text = "    -   ";


        public static string Model1_Sensor_Name1 = "S_001";
        public static string Model1_Sensor_Name2 = "S_002";
        public static string Model1_Sensor_Name3 = "S_003";
        public static string Model1_Sensor_Name4 = "S_004";
        public static string Model1_Sensor_Name5 = "S_005";
        public static string Model1_Sensor_Name6 = "S_006";

        public static void WriteLog(string message)
        {
            // 로그 작성 로직 (예: 파일에 쓰기, 콘솔에 출력 등)
            Console.WriteLine(message);
        }
    }
}