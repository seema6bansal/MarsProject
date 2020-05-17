using MarsProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProject.FeaturesSteps
{
    [Binding]
    class ProfileSteps
    {
        [Given(@"Seller is on the profile page and click on Education tab")]
        public void GivenSellerIsOnTheProfilePageAndClickOnEducationTab()
        {
            ProfilePage.ValidateProfilePage();
            ProfilePage.ClickEducation();

        }

        [When(@"Seller add a new education with '(.*)', '(.*)', '(.*)', '(.*)' and (.*) and click on Add button")]
        public void WhenSellerAddANewEducationWithAnd(string university, string country, string title, string degree, int year)
        {
            ProfilePage.AddEducation(university, country, title, degree, year);

        }

        [Then(@"Education should be added on the profile page")]
        public void ThenEducationShouldBeAddedOnTheProfilePage()
        {
            ProfilePage.ValidateAddedEducation();

        }

        [When(@"Seller select the Education record '(.*)' and click on edit icon")]
        public void WhenSellerSelectTheEducationRecordAndClickOnEditIcon(string title)
        {
            ProfilePage.ClickEditEducation(title);
        }

        [When(@"Update the record with '(.*)' and '(.*)' and click on Update button")]
        public void WhenUpdateTheRecordWithAndAndCickOnUpdateButton(string university, string country)
        {
            ProfilePage.UpdateEducation(university, country);
        }

        [Then(@"Education should be updated on the profile page")]
        public void ThenEducationShouldBeUpdatedOnTheProfilePage()
        {
            ProfilePage.ValidateUpdatedEducation();
        }

        [When(@"Seller select the Education record '(.*)' and click on delete icon")]
        public void WhenSellerSelectTheRecordAndClickOnDeleteIcon(string title1)
        {
            ProfilePage.DeleteEducation(title1);
        }

        [Then(@"Education should be deleted on the profile page")]
        public void ThenEducationShouldBeDeletedOnTheProfilePage()
        {
            ProfilePage.ValidateDeletedEducation();
        }


    }
}
