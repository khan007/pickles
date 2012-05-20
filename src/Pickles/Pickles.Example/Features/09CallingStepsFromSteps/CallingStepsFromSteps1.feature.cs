﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.0.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable

namespace Pickles.Example.Features._09CallingStepsFromSteps
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calling Steps from StepDefinitions")]
    public partial class CallingStepsFromStepDefinitionsFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "CallingStepsFromSteps.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Calling Steps from StepDefinitions",
                                                                "In order to create steps of a higher abstraction\r\nAs a SpecFlow evangelist\r\nI wan" +
                                                                "t reuse other steps in my step definitions",
                                                                ProgrammingLanguage.CSharp, ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Log in")]
        public virtual void LogIn()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Log in", ((string[]) (null)));
#line 6
            this.ScenarioSetup(scenarioInfo);
#line 7
            testRunner.Given("I am on the index page");
#line 8
            testRunner.When("I enter my unsername nad password");
#line 9
            testRunner.And("I click the login button");
#line 10
            testRunner.Then("the welcome page should be displayed");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Do something meaningful")]
        public virtual void DoSomethingMeaningful()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Do something meaningful", ((string[]) (null)));
#line 12
            this.ScenarioSetup(scenarioInfo);
#line 13
            testRunner.Given("I am logged in");
#line 14
            testRunner.When("I dosomething meaningful");
#line 15
            testRunner.Then("I should get rewarded");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion