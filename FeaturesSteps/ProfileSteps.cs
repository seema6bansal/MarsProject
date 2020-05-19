using MarsProject.Helpers;
using MarsProject.Pages;
using NUnit.Framework;
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
        [Given(@"Seller clicks on Education tab on the profile page")]
        public void GivenSellerClicksOnEducationTabOnTheProfilePage()
        {
            ProfilePage.ProfilePageTitle();
            Assert.AreEqual(ProfilePage.actualProfileTitle, ConstantHelpers.expectedProfileTitle);

            ProfilePage.ClickEducation();

        }

        [When(@"Seller adds a new education with '(.*)', '(.*)', '(.*)', '(.*)' and (.*)")]
        public void WhenSellerAddsANewEducationWithAnd(string university, string country, string title, string degree, int year)
        {
            ProfilePage.AddEducation(university, country, title, degree, year);

        }

        [Then(@"Education should be added on the profile page")]
        public void ThenEducationShouldBeAddedOnTheProfilePage()
        {
            ProfilePage.PopUpMsg();
            Assert.AreEqual("Education has been added", ProfilePage.popUpMessage.Text);

        }

        [When(@"Seller selects the Education record '(.*)' for update")]
        public void WhenSellerSelectsTheEducationRecordForUpdate(string title)
        {
            ProfilePage.ClickEditEducation(title);
        }

        [When(@"Updates the record with '(.*)' and '(.*)'")]
        public void WhenUpdatesTheRecordWithAnd(string university, string country)
        {
            ProfilePage.UpdateEducation(university, country);
        }

        [Then(@"Education should be updated on the profile page")]
        public void ThenEducationShouldBeUpdatedOnTheProfilePage()
        {
            ProfilePage.PopUpMsg();
            Assert.AreEqual("Education as been updated", ProfilePage.popUpMessage.Text);
        }

        [When(@"Seller deletes the Education record '(.*)'")]
        public void WhenSellerDeletesTheEducationRecord(string title1)
        {
            ProfilePage.DeleteEducation(title1);
        }

        [Then(@"Education should be deleted on the profile page")]
        public void ThenEducationShouldBeDeletedOnTheProfilePage()
        {
            ProfilePage.PopUpMsg();
            Assert.AreEqual("Education entry successfully removed", ProfilePage.popUpMessage.Text);
        }


    }
}
