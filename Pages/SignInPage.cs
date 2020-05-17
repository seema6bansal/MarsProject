using MarsProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Pages
{
    public static class SignInPage
    {
        public static void SignInStep()
        {
            Driver.NavigateUrl();

            //Find SignIn button and click
            Driver.driver.FindElement(By.XPath("//a[@class='item' and text()='Sign In']")).Click();

            //Enter user name
            Driver.driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("seema.mvp@gmail.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("mvp@2020");

            //Click on login button
            Driver.driver.FindElement(By.XPath("//button[ text()='Login']")).Click();
        }
    }
}
