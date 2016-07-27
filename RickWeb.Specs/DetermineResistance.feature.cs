﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RickWeb.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CalculateResistance")]
    public partial class CalculateResistanceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DetermineResistance.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CalculateResistance", "    In order to determine the resistance of a resistor\r\n    As a young physicist\r" +
                    "\n    I want to be calculate the resistance using the color bands", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Determine resistance of a resistor with a tolerance")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void DetermineResistanceOfAResistorWithATolerance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine resistance of a resistor with a tolerance", new string[] {
                        "ignore"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Resistor",
                        "Band A",
                        "Band B",
                        "Band C",
                        "Band D"});
            table1.AddRow(new string[] {
                        "1",
                        "Yellow",
                        "Violet",
                        "Red",
                        "Gold"});
            table1.AddRow(new string[] {
                        "2",
                        "Blue",
                        "Red",
                        "Black",
                        "Silver"});
            table1.AddRow(new string[] {
                        "3",
                        "White",
                        "Green",
                        "Violet",
                        "Brown"});
            table1.AddRow(new string[] {
                        "4",
                        "White",
                        "Gray",
                        "Green",
                        "Green"});
            table1.AddRow(new string[] {
                        "5",
                        "Brown",
                        "Orange",
                        "Red",
                        "Blue"});
#line 8
    testRunner.Given("I have resistor with the bands", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Resistor",
                        "Band A",
                        "Band B",
                        "Band C",
                        "Band D"});
            table2.AddRow(new string[] {
                        "1",
                        "Yellow",
                        "Violet",
                        "Red",
                        "Gold"});
            table2.AddRow(new string[] {
                        "2",
                        "Blue",
                        "Red",
                        "Black",
                        "Silver"});
            table2.AddRow(new string[] {
                        "3",
                        "White",
                        "Green",
                        "Violet",
                        "Brown"});
            table2.AddRow(new string[] {
                        "4",
                        "White",
                        "Gray",
                        "Green",
                        "Green"});
            table2.AddRow(new string[] {
                        "5",
                        "Brown",
                        "Orange",
                        "Red",
                        "Blue"});
#line 15
    testRunner.When("I enter these colors", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Resistor",
                        "Nominal Resistance",
                        "Tolerance"});
            table3.AddRow(new string[] {
                        "1",
                        "4700 ohms",
                        "5%"});
            table3.AddRow(new string[] {
                        "2",
                        "62 ohms",
                        "10%"});
            table3.AddRow(new string[] {
                        "3",
                        "950 Mohms",
                        "1%"});
            table3.AddRow(new string[] {
                        "4",
                        "9.8 Mohms",
                        "0.5%"});
            table3.AddRow(new string[] {
                        "5",
                        "1.3 kohms",
                        "0.25%"});
#line 22
    testRunner.Then("I see the resistance", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Determine resistance of a resistor with no tolerance")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void DetermineResistanceOfAResistorWithNoTolerance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine resistance of a resistor with no tolerance", new string[] {
                        "ignore"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Determine resistance of a resistor with three significant figures")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void DetermineResistanceOfAResistorWithThreeSignificantFigures()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine resistance of a resistor with three significant figures", new string[] {
                        "ignore"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Determine resistance of a resistor with a temperature coefficent")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void DetermineResistanceOfAResistorWithATemperatureCoefficent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine resistance of a resistor with a temperature coefficent", new string[] {
                        "ignore"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Determine resistance of a single band resistor")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void DetermineResistanceOfASingleBandResistor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine resistance of a single band resistor", new string[] {
                        "ignore"});
#line 40
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Determine resistance of a resistor with an illegal band")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void DetermineResistanceOfAResistorWithAnIllegalBand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine resistance of a resistor with an illegal band", new string[] {
                        "ignore"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Band D"});
            table4.AddRow(new string[] {
                        "Black"});
            table4.AddRow(new string[] {
                        "Orange"});
            table4.AddRow(new string[] {
                        "White"});
#line 44
 testRunner.Given("I have a resister with the bands", ((string)(null)), table4, "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
