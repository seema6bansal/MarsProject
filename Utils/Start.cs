using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MarsProject.Helpers;
using MarsProject.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace MarsProject.Utils
{
    [Binding]
    public class Start : Driver
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static ScenarioContext scenarioContextCurrent;


        public Start(ScenarioContext scenarioContext)
        {
            scenarioContextCurrent = scenarioContext;
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {

            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);

        }

        [BeforeScenario]
        public void Setup()
        {
            //TODO: implement logic that has to run before executing each scenario

            scenario = featureName.CreateNode<Scenario>(scenarioContextCurrent.ScenarioInfo.Title);

            //Launch the browser
            Initialize();

            //Call SignIn page
            SignInPage.SignInStep();

        }

        [AfterStep]
        public static void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (scenarioContextCurrent.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (scenarioContextCurrent.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContextCurrent.TestError.Message);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContextCurrent.TestError.Message);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContextCurrent.TestError.Message);
            }

        }


        [AfterScenario]
        public void TearDown()
        {
            //TODO: implement logic that has to run after executing each scenario

            //Close the browser
            Close();

        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            //Calling Flush to write everything to the Report
            extent.Flush();

        }
    }
}
