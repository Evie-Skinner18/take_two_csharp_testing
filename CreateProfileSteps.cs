using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

// to access Selenium class we need to open the door to it
using OpenQA.Selenium;

//need to access chrome driver
using OpenQA.Selenium.Chrome;

using TechTalk.SpecFlow;

namespace csharp_ui_take_two
{
    [Binding]
    public class CreateProfileSteps
    {
        // create an object of the webdriver that is PUBLIC so now all the methods can see it
        public IWebDriver driver;

        // @valid_login
        [Given(@"I am on the log in page")]
        public void GivenIAmOnTheLogInPage()
        {
            // I think this creates an instance of chrome driver
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\TECH-W77\Documents\take_two_csharp_framework-dev\chromedriver_win32", "chromedriver.exe");

            // Launch browser
            driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // Navigate to homepage URL
            driver.Navigate().GoToUrl("https://37a4a4e2.ngrok.io/login");
        }
        
        [Given(@"I enter my details")]
        public void GivenIEnterMyDetails()
        {
            // Csharp needs double quotation marks as a MUST. so change the dbl ones e.g inside an xpath to single ones to make Csharp comfy.
            // Ooh she's a bit of a diva this Csharp!
            driver.FindElement(By.Name("email")).SendKeys("ttest2@spartaglobal.com");

            // Enter the valid password in password bar
            driver.FindElement(By.Name("password")).SendKeys("Tr4iner");
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            // Click the submit button
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div/div/form/div[3]/input")).Click();
        }

        [Then(@"I should be redirected to the profiles index page")]
        public void ThenIShouldBeRedirectedToTheProfilesIndexPage()
        {
            //check if succesful
            driver.FindElement(By.XPath("/html/body/div/nav/ul/li[1]/a"));

            //close the application
            driver.Close();
        }

        // @create_profile
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            // I think this creates an instance of chrome driver
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\TECH-W77\Documents\take_two_csharp_framework-dev\chromedriver_win32", "chromedriver.exe");

            // Launch browser
            driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // Navigate to homepage URL
            driver.Navigate().GoToUrl("https://8ddba250.ngrok.io/login");

            // log in successfully
            driver.FindElement(By.Name("email")).SendKeys("ttest2@spartaglobal.com");
            driver.FindElement(By.Name("password")).SendKeys("Tr4iner");
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div/div/form/div[3]/input")).Click();

            //check if succesful
            driver.FindElement(By.XPath("/html/body/div/nav/ul/li[1]/a"));
        }

        [When(@"I click new profile")]
        public void WhenIClickNewProfile()
        {
            driver.FindElement(By.LinkText("Create a profile")).Click();
        }

        [When(@"add the correct details")]
        public void WhenAddTheCorrectDetails()
        {
            driver.FindElement(By.Id("profile_summary")).SendKeys("Tbh mixtape lomo craft beer, polaroid kale chips vexillologist cray chambray narwhal activated charcoal literally. Trust fund kinfolk hexagon neutra, blue bottle next level gentrify shaman iceland fashion axe four loko raw denim helvetica. Semiotics cray readymade, swag chillwave pork belly food truck. Shoreditch twee tofu leggings you probably haven't heard of them vexillologist. Readymade fam small batch neutra farm-to-table chambray plaid you probably haven't heard of them hot chicken flannel taxidermy. Man braid raclette plaid heirloom chia.");
            IWebElement select = driver.FindElement(By.TagName("select"));
            IList<IWebElement> allOptions = select.FindElements(By.TagName("option"));
            foreach (IWebElement option in allOptions)
                {
                    option.Click();
                } //end of foreach

            driver.FindElement(By.Id("profile_degree")).SendKeys("BSc Cheesemaking");
            driver.FindElement(By.CssSelector("input[value='Save']")).Submit();
         }

        [Then(@"it should show me the profile on the index page")]
        public void ThenItShouldShowMeTheProfileOnTheIndexPage()
        {
            // navigate back to index page
            driver.FindElement(By.LinkText("Back to Profiles")).Click();

            //check that the CRUD links are there
            bool pageHasEditLink =  driver.FindElement(By.LinkText("Edit")).Displayed;
            bool pageHasDownloadLink = driver.FindElement(By.LinkText("Download")).Displayed;
            bool pageHasDestroyLink = driver.FindElement(By.LinkText("Destroy")).Displayed;
            //close the application
            driver.Close();

        }

        // @choose_Stream
        [Given(@"there is already a profile created")]
        public void GivenThereIsAlreadyAProfileCreated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the project section")]
        public void GivenINavigateToTheProjectSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"that I am logged in")]
        public void GivenThatIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the Employment page")]
        public void GivenINavigateToTheEmploymentPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill out the Employment form correctly")]
        public void GivenIFillOutTheEmploymentFormCorrectly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I edit the information in the form")]
        public void GivenIEditTheInformationInTheForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the Education page")]
        public void GivenINavigateToTheEducationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill out the Education form correctly")]
        public void GivenIFillOutTheEducationFormCorrectly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the Certification page")]
        public void GivenINavigateToTheCertificationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill out the Certification form correctly")]
        public void GivenIFillOutTheCertificationFormCorrectly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the Custom page")]
        public void GivenINavigateToTheCustomPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill out the Custom form correctly")]
        public void GivenIFillOutTheCustomFormCorrectly()
        {
            ScenarioContext.Current.Pending();
        }
        
              
        [When(@"I click create a profile")]
        public void WhenIClickCreateAProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the profile")]
        public void WhenIClickOnTheProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click edit")]
        public void WhenIClickEdit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"change the details on my profile form")]
        public void WhenChangeTheDetailsOnMyProfileForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click to delete the profile")]
        public void WhenIClickToDeleteTheProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I create a new profile")]
        public void WhenICreateANewProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click save")]
        public void WhenClickSave()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click download on an already created profile")]
        public void WhenIClickDownloadOnAnAlreadyCreatedProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click the download button on the PDF viewer")]
        public void WhenClickTheDownloadButtonOnThePDFViewer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click to add a new project")]
        public void WhenIClickToAddANewProject()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"fill in the correct details of my project")]
        public void WhenFillInTheCorrectDetailsOfMyProject()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click a project")]
        public void WhenIClickAProject()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click to delete a project")]
        public void WhenIClickToDeleteAProject()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click save")]
        public void WhenIClickSave()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click Destroy")]
        public void WhenIClickDestroy()
        {
            ScenarioContext.Current.Pending();
        }
                        
        [Then(@"I should be given a drop down list of streams to choose from")]
        public void ThenIShouldBeGivenADropDownListOfStreamsToChooseFrom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should show me the profile")]
        public void ThenItShouldShowMeTheProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should show the updated details on the id page")]
        public void ThenItShouldShowTheUpdatedDetailsOnTheIdPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should remove the profile from that page")]
        public void ThenItShouldRemoveTheProfileFromThatPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should redirect me to that specific profiles page")]
        public void ThenItShouldRedirectMeToThatSpecificProfilesPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should redirect me to the profile as a PDF document")]
        public void ThenItShouldRedirectMeToTheProfileAsAPDFDocument()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should download the file")]
        public void ThenItShouldDownloadTheFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should show my project on the index")]
        public void ThenItShouldShowMyProjectOnTheIndex()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should show my project id page")]
        public void ThenItShouldShowMyProjectIdPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should not show my project on the index")]
        public void ThenItShouldNotShowMyProjectOnTheIndex()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Employment confirmation message")]
        public void ThenIShouldSeeTheEmploymentConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Employment update confirmation message")]
        public void ThenIShouldSeeTheEmploymentUpdateConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Employment destroyed confirmation message")]
        public void ThenIShouldSeeTheEmploymentDestroyedConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Education confirmation message")]
        public void ThenIShouldSeeTheEducationConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Education update confirmation message")]
        public void ThenIShouldSeeTheEducationUpdateConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Education destroyed confirmation message")]
        public void ThenIShouldSeeTheEducationDestroyedConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Certification confirmation message")]
        public void ThenIShouldSeeTheCertificationConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Certification update confirmation message")]
        public void ThenIShouldSeeTheCertificationUpdateConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Certification destroyed confirmation message")]
        public void ThenIShouldSeeTheCertificationDestroyedConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Custom confirmation message")]
        public void ThenIShouldSeeTheCustomConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Custom update confirmation message")]
        public void ThenIShouldSeeTheCustomUpdateConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the Custom destroyed confirmation message")]
        public void ThenIShouldSeeTheCustomDestroyedConfirmationMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
