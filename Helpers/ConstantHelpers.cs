﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string url = "http://192.168.99.100:5000";

        //ExtentReportsPath
        public static string reportsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestReports\\");

    }
}
