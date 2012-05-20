﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
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

namespace Pickles.Example.xUnit.Features
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ArithmeticFeature : Xunit.IUseFixture<ArithmeticFeature.FixtureData>, System.IDisposable
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "Arithmetic.feature"
#line hidden

        public ArithmeticFeature()
        {
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Arithmetic",
                                                                "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be able to perform a" +
                                                                "rithmetic on the calculator",
                                                                ProgrammingLanguage.CSharp, ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

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

        public virtual void SetFixture(ArithmeticFeature.FixtureData fixtureData)
        {
        }

        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Arithmetic")]
        [Xunit.TraitAttribute("Description", "Add two numbers")]
        public virtual void AddTwoNumbers()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", new string[]
                                                                                         {
                                                                                             "arithmetic",
                                                                                             "fast"
                                                                                         });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("I have entered 50 into the calculator");
#line 9
            testRunner.And("I have entered 70 into the calculator");
#line 10
            testRunner.When("I press add");
#line 11
            testRunner.Then("the result should be 120 on the screen");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Arithmetic")]
        [Xunit.TraitAttribute("Description", "Subtract two numbers")]
        public virtual void SubtractTwoNumbers()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtract two numbers", new string[]
                                                                                              {
                                                                                                  "arithmetic",
                                                                                                  "fast"
                                                                                              });
#line 14
            this.ScenarioSetup(scenarioInfo);
#line 15
            testRunner.Given("I have entered 50 into the calculator");
#line 16
            testRunner.And("I have entered 70 into the calculator");
#line 17
            testRunner.When("I press subtract");
#line 18
            testRunner.Then("the result should be -20 on the screen");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Arithmetic")]
        [Xunit.TraitAttribute("Description", "Multiply two numbers")]
        public virtual void MultiplyTwoNumbers()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiply two numbers", new string[]
                                                                                              {
                                                                                                  "arithmetic",
                                                                                                  "fast"
                                                                                              });
#line 21
            this.ScenarioSetup(scenarioInfo);
#line 22
            testRunner.Given("I have entered 50 into the calculator");
#line 23
            testRunner.And("I have entered 70 into the calculator");
#line 24
            testRunner.When("I press multiply");
#line 25
            testRunner.Then("the result should be 3500 on the screen");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Arithmetic")]
        [Xunit.TraitAttribute("Description", "Divide two numbers")]
        public virtual void DivideTwoNumbers()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Divide two numbers", new string[]
                                                                                            {
                                                                                                "arithmetic",
                                                                                                "fast"
                                                                                            });
#line 28
            this.ScenarioSetup(scenarioInfo);
#line 29
            testRunner.Given("I have entered 50 into the calculator");
#line 30
            testRunner.And("I have entered 2 into the calculator");
#line 31
            testRunner.When("I press divide");
#line 32
            testRunner.Then("the result should be 25 on the screen");
#line hidden
            this.ScenarioCleanup();
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            public FixtureData()
            {
                FeatureSetup();
            }

            #region IDisposable Members

            void System.IDisposable.Dispose()
            {
                FeatureTearDown();
            }

            #endregion
        }
    }
}

#pragma warning restore

#endregion