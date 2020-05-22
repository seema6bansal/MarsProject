using AventStack.ExtentReports.Gherkin.Model;
using MarsProject.Helpers;
using MarsProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace MarsProject.FeaturesSteps
{
    [Binding]
    class ProfileSteps
    {
        [Given(@"Seller clicks on Education tab on the profile page")]
        public void GivenSellerClicksOnEducationTabOnTheProfilePage()
        {
            ProfilePage.ClickEducation();

        }

        [When(@"Seller adds a new education with the following data:")]
        public void WhenSellerAddsANewEducationWithFollowingData(Table table)
        {
            var details = table.CreateSet<EducationDetails>();

            foreach(EducationDetails education in details)
            {
                ProfilePage.AddEducation(education.University, education.Country, education.Title, education.Degree, education.Year);
            }

        }

        [Then(@"Education should be added on the profile page")]
        public void ThenEducationShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual("Education has been added", ProfilePage.GetPopUp());

        }

        [When(@"Seller selects the Education record '(.*)' for update")]
        public void WhenSellerSelectsTheEducationRecordForUpdate(string title)
        {
            ProfilePage.ClickEditEducation(title);

        }

        [When(@"Updates University '(.*)'")]
        public void WhenUpdatesUniversity(string university)
        {
            ProfilePage.UpdateUniversity(university);

        }

        [When(@"Updates Country '(.*)'")]
        public void WhenUpdatesCountry(string country)
        {
            ProfilePage.UpdateCountry(country);

        }

        [When(@"Saves the Education details")]
        public void WhenSavesTheEducationDetails()
        {
             ProfilePage.SaveEducation();
        }

        [Then(@"Education should be updated on the profile page")]
        public void ThenEducationShouldBeUpdatedOnTheProfilePage()
        {
           Assert.AreEqual("Education as been updated", ProfilePage.GetPopUp());

        }

        [When(@"Seller deletes the Education record '(.*)'")]
        public void WhenSellerDeletesTheEducationRecord(string title1)
        {
            ProfilePage.DeleteEducation(title1);

        }

        [Then(@"Education should be deleted on the profile page")]
        public void ThenEducationShouldBeDeletedOnTheProfilePage()
        {
            Assert.AreEqual("Education entry successfully removed", ProfilePage.GetPopUp());

        }


    }
}
