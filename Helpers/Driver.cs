using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Helpers
{
    public class Driver
    {
        //Initialize the driver
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.url; }
        }

        
        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser
        public static void Close()
        {
            driver.Quit();
        }


    }
}
