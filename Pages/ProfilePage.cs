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

        public static void ValidateProfilePage()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.UrlToBe(ConstantHelpers.expectedProfileTitle));
            string actualProfileTitle = Driver.driver.Url;
            Assert.AreEqual(actualProfileTitle, ConstantHelpers.expectedProfileTitle);

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
            IWebElement element1 = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement countrySelect = new SelectElement(element1);
            countrySelect.SelectByValue(country);

            //Select Title 
            IWebElement element2 = Driver.driver.FindElement(By.Name("title"));
            SelectElement titleSelect = new SelectElement(element2);
            titleSelect.SelectByValue(title);

            //Find Degree Text box and send data
            Driver.driver.FindElement(By.Name("degree")).SendKeys(degree);

            //Select Year of graduation
            IWebElement element3 = Driver.driver.FindElement(By.Name("yearOfGraduation"));
            SelectElement yearSelect = new SelectElement(element3);
            yearSelect.SelectByValue(year.ToString());

            //Find Add button and click on that
            Driver.driver.FindElement(By.XPath("//input[@value ='Add']")).Click();
            Thread.Sleep(1000);

        }

        public static void ValidateAddedEducation()
        {
            //Validate if Education record added successfully
            IWebElement addedPopMsg = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            Assert.AreEqual("Education has been added", addedPopMsg.Text);

        }

        public static void ClickEditEducation(string title)
        {
            //Validate if Education record is on the profile page and then update it
            IWebElement actualData = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[1]//tr/td[3]"));

            if ((actualData.Text).Equals(title))
            {
                Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[last()]//tr/td[6]//span[1]")).Click();
            }
            Thread.Sleep(2000);

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
            Thread.Sleep(2000);

        }

        public static void ValidateUpdatedEducation()
        {
            //Validate if Education record updated successfully
            IWebElement updatedPopMsg = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            Assert.AreEqual("Education as been updated", updatedPopMsg.Text);

        }

        public static void DeleteEducation(string title1)
        {
            //Validate if Education record is on the profile page and then delete it
            IWebElement deleteData = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[2]//tr/td[3]"));

            if ((deleteData.Text).Equals(title1))
            {
                Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]//tbody)[2]//tr/td[6]//span[2]")).Click();
            }
            Thread.Sleep(2000);

        }

        public static void ValidateDeletedEducation()
        {
            //Validate if Education record deleted successfully
            IWebElement deletedPopMsg = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            Assert.AreEqual("Education entry successfully removed", deletedPopMsg.Text);

        }



    }
}
