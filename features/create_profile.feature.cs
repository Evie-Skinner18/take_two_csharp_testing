﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace csharp_ui_take_two.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("As a trainee I should be able to create a profile")]
    public partial class AsATraineeIShouldBeAbleToCreateAProfileFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "create_profile.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "As a trainee I should be able to create a profile", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Using valid details I should be able to log in")]
        public virtual void UsingValidDetailsIShouldBeAbleToLogIn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using valid details I should be able to log in", ((string[])(null)));
#line 3
  this.ScenarioSetup(scenarioInfo);
#line 4
    testRunner.Given("I am on the log in page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
    testRunner.And("I enter my details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
    testRunner.When("I click submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
    testRunner.Then("I should be redirected to the profiles index page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to create a profile")]
        public virtual void IShouldBeAbleToCreateAProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to create a profile", ((string[])(null)));
#line 9
  this.ScenarioSetup(scenarioInfo);
#line 10
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
    testRunner.When("I click new profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.And("add the correct details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.Then("it should show me the profile on the index page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to choose my education stream at the academy")]
        public virtual void IShouldBeAbleToChooseMyEducationStreamAtTheAcademy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to choose my education stream at the academy", ((string[])(null)));
#line 15
  this.ScenarioSetup(scenarioInfo);
#line 16
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
    testRunner.When("I click create a profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
    testRunner.Then("I should be given a drop down list of streams to choose from", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to view an already created profile")]
        public virtual void IShouldBeAbleToViewAnAlreadyCreatedProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to view an already created profile", ((string[])(null)));
#line 20
  this.ScenarioSetup(scenarioInfo);
#line 21
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
    testRunner.And("there is already a profile created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.When("I click on the profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
    testRunner.Then("it should show me the profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to edit my profile")]
        public virtual void IShouldBeAbleToEditMyProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to edit my profile", ((string[])(null)));
#line 26
  this.ScenarioSetup(scenarioInfo);
#line 27
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
    testRunner.When("I click edit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
    testRunner.And("change the details on my profile form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
    testRunner.Then("it should show the updated details on the id page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to delete a profile")]
        public virtual void IShouldBeAbleToDeleteAProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to delete a profile", ((string[])(null)));
#line 32
  this.ScenarioSetup(scenarioInfo);
#line 33
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
    testRunner.And("there is already a profile created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.When("I click to delete the profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.Then("it should remove the profile from that page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to view my profile straight after completion")]
        public virtual void IShouldBeAbleToViewMyProfileStraightAfterCompletion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to view my profile straight after completion", ((string[])(null)));
#line 38
  this.ScenarioSetup(scenarioInfo);
#line 39
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
    testRunner.When("I create a new profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
    testRunner.And("click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.Then("it should redirect me to that specific profiles page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to view my profile as a PDF document")]
        public virtual void IShouldBeAbleToViewMyProfileAsAPDFDocument()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to view my profile as a PDF document", ((string[])(null)));
#line 44
  this.ScenarioSetup(scenarioInfo);
#line 45
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
    testRunner.When("I click download on an already created profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
    testRunner.Then("it should redirect me to the profile as a PDF document", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to download my profile")]
        public virtual void IShouldBeAbleToDownloadMyProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to download my profile", ((string[])(null)));
#line 49
  this.ScenarioSetup(scenarioInfo);
#line 50
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
    testRunner.When("I click download on an already created profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
    testRunner.And("click the download button on the PDF viewer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.Then("it should download the file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to add a new project")]
        public virtual void IShouldBeAbleToAddANewProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to add a new project", ((string[])(null)));
#line 56
  this.ScenarioSetup(scenarioInfo);
#line 57
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
    testRunner.And("I navigate to the project section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.When("I click to add a new project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
    testRunner.And("fill in the correct details of my project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.Then("it should show my project on the index", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to view a project")]
        public virtual void IShouldBeAbleToViewAProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to view a project", ((string[])(null)));
#line 63
  this.ScenarioSetup(scenarioInfo);
#line 64
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
    testRunner.And("I navigate to the project section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
    testRunner.When("I click a project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
    testRunner.Then("it should show my project id page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to delete a project")]
        public virtual void IShouldBeAbleToDeleteAProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to delete a project", ((string[])(null)));
#line 69
  this.ScenarioSetup(scenarioInfo);
#line 70
    testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
    testRunner.And("I navigate to the project section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
    testRunner.When("I click to delete a project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
    testRunner.Then("it should not show my project on the index", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to add an Employment section")]
        public virtual void IWantToAddAnEmploymentSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to add an Employment section", ((string[])(null)));
#line 75
  this.ScenarioSetup(scenarioInfo);
#line 76
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
    testRunner.And("I navigate to the Employment page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
    testRunner.And("I fill out the Employment form correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
    testRunner.Then("I should see the Employment confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to update my existing Employment section")]
        public virtual void IWantToUpdateMyExistingEmploymentSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to update my existing Employment section", ((string[])(null)));
#line 82
  this.ScenarioSetup(scenarioInfo);
#line 83
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
    testRunner.And("I navigate to the Employment page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
    testRunner.And("I edit the information in the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
    testRunner.Then("I should see the Employment update confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to delete an Employment section")]
        public virtual void IWantToDeleteAnEmploymentSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to delete an Employment section", ((string[])(null)));
#line 89
  this.ScenarioSetup(scenarioInfo);
#line 90
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
    testRunner.And("I navigate to the Employment page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
    testRunner.When("I click Destroy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
    testRunner.Then("I should see the Employment destroyed confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to add an Education section")]
        public virtual void IWantToAddAnEducationSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to add an Education section", ((string[])(null)));
#line 95
  this.ScenarioSetup(scenarioInfo);
#line 96
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
    testRunner.And("I navigate to the Education page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
    testRunner.And("I fill out the Education form correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
    testRunner.Then("I should see the Education confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to update my existing Education section")]
        public virtual void IWantToUpdateMyExistingEducationSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to update my existing Education section", ((string[])(null)));
#line 102
  this.ScenarioSetup(scenarioInfo);
#line 103
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
    testRunner.And("I navigate to the Education page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
    testRunner.And("I edit the information in the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
    testRunner.Then("I should see the Education update confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to delete an Education section")]
        public virtual void IWantToDeleteAnEducationSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to delete an Education section", ((string[])(null)));
#line 109
  this.ScenarioSetup(scenarioInfo);
#line 110
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
    testRunner.And("I navigate to the Education page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
    testRunner.When("I click Destroy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
    testRunner.Then("I should see the Education destroyed confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to add a Certification section")]
        public virtual void IWantToAddACertificationSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to add a Certification section", ((string[])(null)));
#line 115
  this.ScenarioSetup(scenarioInfo);
#line 116
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 117
    testRunner.And("I navigate to the Certification page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
    testRunner.And("I fill out the Certification form correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
    testRunner.Then("I should see the Certification confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to update my existing Certification section")]
        public virtual void IWantToUpdateMyExistingCertificationSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to update my existing Certification section", ((string[])(null)));
#line 122
  this.ScenarioSetup(scenarioInfo);
#line 123
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
    testRunner.And("I navigate to the Certification page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
    testRunner.And("I edit the information in the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
    testRunner.Then("I should see the Certification update confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to delete a Certification  section")]
        public virtual void IWantToDeleteACertificationSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to delete a Certification  section", ((string[])(null)));
#line 129
  this.ScenarioSetup(scenarioInfo);
#line 130
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
    testRunner.And("I navigate to the Certification page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
    testRunner.When("I click Destroy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
    testRunner.Then("I should see the Certification destroyed confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to add a Custom section")]
        public virtual void IWantToAddACustomSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to add a Custom section", ((string[])(null)));
#line 135
  this.ScenarioSetup(scenarioInfo);
#line 136
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 137
    testRunner.And("I navigate to the Custom page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
    testRunner.And("I fill out the Custom form correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
    testRunner.Then("I should see the Custom confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to update my existing Custom section")]
        public virtual void IWantToUpdateMyExistingCustomSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to update my existing Custom section", ((string[])(null)));
#line 142
  this.ScenarioSetup(scenarioInfo);
#line 143
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 144
    testRunner.And("I navigate to the Custom page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
    testRunner.And("I edit the information in the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
    testRunner.When("I click save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
    testRunner.Then("I should see the Custom update confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to delete a Custom section")]
        public virtual void IWantToDeleteACustomSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to delete a Custom section", ((string[])(null)));
#line 149
  this.ScenarioSetup(scenarioInfo);
#line 150
    testRunner.Given("that I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 151
    testRunner.And("I navigate to the Custom page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
    testRunner.When("I click Destroy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
    testRunner.Then("I should see the Custom destroyed confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
