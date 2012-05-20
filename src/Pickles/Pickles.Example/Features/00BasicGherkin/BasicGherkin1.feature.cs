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

namespace Pickles.Example.Features._00BasicGherkin
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Showing basic gherkin syntax")]
    public partial class ShowingBasicGherkinSyntaxFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "BasicGherkin.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Showing basic gherkin syntax",
                                                                "In order to see that gherkin is a very simple langauge\r\nAs a SpecFlow evangelist\r" +
                                                                "\nI want to show that basic syntax",
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
        [NUnit.Framework.DescriptionAttribute("Simple GWT")]
        public virtual void SimpleGWT()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simple GWT", ((string[]) (null)));
#line 6
            this.ScenarioSetup(scenarioInfo);
#line 7
            testRunner.Given("the initial state of the application is Running");
#line 8
            testRunner.When("I ask what the application state is");
#line 9
            testRunner.Then("I should see Running as the answer");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using And and But")]
        public virtual void UsingAndAndBut()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using And and But", ((string[]) (null)));
#line 11
            this.ScenarioSetup(scenarioInfo);
#line 12
            testRunner.Given("the initial state of the application is Running");
#line 13
            testRunner.And("I have authorization to ask application state");
#line 14
            testRunner.When("I ask what the application state is");
#line 15
            testRunner.Then("I should see Running as the answer");
#line 16
            testRunner.And("I should see the time of the application");
#line 17
            testRunner.But("the state of the application should not be Stopped");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion