using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using OpenQA.Selenium.Support.UI;
using MarsProject.Helpers;
using System.Threading;
using NUnit.Framework;

namespace MarsProject.Pages
{
    class ProfilePage
    {
        public static string actualProfileTitle;
        public static IWebElement popUpMessage;

        public static string ProfilePageTitle()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.UrlToBe(ConstantHelpers.expectedProfileTitle));
            actualProfileTitle = Driver.driver.Url;
            return actualProfileTitle;

        }

        public static void ClickEducation()
        {
            //Find Education tab and click on that
            WebDriverWait wait1 = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
            IWebElement education = wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),'Education')]")));
            education.Click();

        }

        public static void AddEducation(string university, string country, string title, string degree, int year)
        {

            //Find Add New button and click on that
            WebDriverWait wait2 = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
            IWebElement addNewButton = wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[contains(text(),'Add New')])[3]")));
            addNewButton.Click();


            //Find College/University Name Text box and send data
            Driver.driver.FindElement(By.Name("instituteName")).SendKeys(university);

            //Select Country of College/University
            IWebElement countryName = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement countrySelect = new SelectElement(countryName);
            countrySelect.SelectByValue(country);

            //Select Title 
            IWebElement titleName = Driver.driver.FindElement(By.Name("title"));
            SelectElement titleSelect = new SelectElement(titleName);
            titleSelect.SelectByValue(title);

            //Find Degree Text box and send data
            Driver.driver.FindElement(By.Name("degree")).SendKeys(degree);

            //Select Year of graduation
            IWebElement graduationYear = Driver.driver.FindElement(By.Name("yearOfGraduation"));
            SelectElement yearSelect = new SelectElement(graduationYear);
            yearSelect.SelectByValue(year.ToString());

            //Find Add button and click on that
            Driver.driver.FindElement(By.XPath("//input[@value ='Add']")).Click();
         
        }

        public static void ClickEditEducation(string title)
        {
            //Validate if Education record is on the profile page and then update it
            IWebElement actualData = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[1]//tr/td[3]"));

            if ((actualData.Text).Equals(title))
            {
                Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[last()]//tr/td[6]//span[1]")).Click();
            }
         
        }

        public static void UpdateEducation(string university, string country)
        {
            //Update College/University Name
            IWebElement UniversityText = Driver.driver.FindElement(By.XPath("//input[@name='instituteName']"));
            UniversityText.Clear();
            UniversityText.SendKeys(university);

            //Update Country of Country
            IWebElement countryElement = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement countrySelect = new SelectElement(countryElement);
            countrySelect.SelectByText(country);

            //Find Update button and click on that
            Driver.driver.FindElement(By.XPath("//div[@class='sixteen wide field']//input[@value='Update']")).Click();
         
        }

        public static void DeleteEducation(string title1)
        {
            //Validate if Education record is on the profile page and then delete it
            IWebElement deleteData = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[2]//tr/td[3]"));

            if ((deleteData.Text).Equals(title1))
            {
                Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[2]//tr/td[6]//span[2]")).Click();
            }

        }

        public static IWebElement PopUpMsg()
        {
            //Find out Popup Message
            WebDriverWait wait3 = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
            popUpMessage = wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ns-box-inner']")));
            return popUpMessage;

        }


    }
}
