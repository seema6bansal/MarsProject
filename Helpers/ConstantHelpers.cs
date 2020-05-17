using System;
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
        public static string Url = "http://192.168.99.100:5000";

        //Expected Profile Title
        public static string expectedProfileTitle = "http://192.168.99.100:5000/Account/Profile";

        //ExtentReportsPath
        public static string ReportsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestReports\\");

    }
}
