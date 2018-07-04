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

namespace csharp_ui_take_two
{
    public class MyClass
    {
        [Test]
        public void SearchTesting()
        {
            // I think this creates an instance of chrome driver
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\TECH-W77\Documents\take_two_csharp_framework-dev\chromedriver_win32", "chromedriver.exe");

            // Launch browser
            IWebDriver driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            // Navigate to URL
            driver.Navigate().GoToUrl("https://37a4a4e2.ngrok.io/login");
            // Click search our articles. Csharp needs double quotation marks as a MUST. so change the dbl ones e.g inside an xpath to single ones to make Csharp comfy.
            // Ooh she's a bit of a diva this Csharp!
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();

            // Enter 'testing' in search bar
            driver.FindElement(By.Id("ct100_MC_Query")).SendKeys("testing");

            // Click the search button
            driver.FindElement(By.Id("ct100_MC_Go")).Click();

            //close the application
            driver.Quit();

        

        }

    }
}
