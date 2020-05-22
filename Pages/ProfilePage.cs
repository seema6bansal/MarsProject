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
        public static void ClickEducation()
        {
            //Find Education tab and click on that
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
            IWebElement education = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),'Education')]")));
            education.Click();

        }

        public static void AddEducation(string university, string country, string title, string degree, int year)
        {

            //Find Add New button and click on that
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(50));
            IWebElement addNewButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[contains(text(),'Add New')])[3]")));
            addNewButton.Click();

            //Find College/University Name Text box and send data
            WebDriverWait universityWait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(50));
            IWebElement universityName = universityWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='instituteName']")));
            universityName.SendKeys(university);
         
            //Select Country of College/University
            IWebElement countryName = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement countrySelect = new SelectElement(countryName);
            countrySelect.SelectByValue(country);

            //Select Title 
            IWebElement titleName = Driver.driver.FindElement(By.XPath("//select[@name='title']"));
            SelectElement titleSelect = new SelectElement(titleName);
            titleSelect.SelectByValue(title);

            //Find Degree Text box and send data
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys(degree);

            //Select Year of graduation
            IWebElement graduationYear = Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            SelectElement yearSelect = new SelectElement(graduationYear);
            yearSelect.SelectByValue(year.ToString());

            //Find Add button and click on that
            Driver.driver.FindElement(By.XPath("//input[@value ='Add']")).Click();
         
        }

        public static void ClickEditEducation(string title)
        {
            //Validate if Education record is on the profile page and then update it
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
            IWebElement actualData = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[1]//tr/td[3]")));

            if ((actualData.Text).Equals(title))
            {
                WebDriverWait editWait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
                (editWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[last()]//tr/td[6]//span[1]")))).Click();
            }
         
        }

        public static void UpdateUniversity(string university)
        {
            //Update College/University Name
            IWebElement universityText = Driver.driver.FindElement(By.XPath("//input[@name='instituteName']"));
            universityText.Clear();
            universityText.SendKeys(university);
        }

        public static void UpdateCountry(string country)
        {
            //Update Country of Country
            IWebElement countryElement = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement countrySelect = new SelectElement(countryElement);
            countrySelect.SelectByText(country);

        }

        public static void SaveEducation() 
        {
            //Find Update button and click on that
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
            (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sixteen wide field']//input[@value='Update']")))).Click();
         
        }

        public static void DeleteEducation(string title1)
        {
            //Validate if Education record is on the profile page and then delete it
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
            IWebElement deleteData = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[2]//tr/td[3]")));

            if ((deleteData.Text).Equals(title1))
            {
                WebDriverWait deleteWait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
                (deleteWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[2]//tr/td[6]//span[2]")))).Click();
            }

        }

        public static string GetPopUp()
        {
            //Find out Popup Message
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
            return (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ns-box-inner']")))).Text;
            

        }


    }
}
