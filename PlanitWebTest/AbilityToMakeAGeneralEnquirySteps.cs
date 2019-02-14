using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace PlanitWebTest
{
    [Binding]
    public class AbilityToMakeAGeneralEnquirySteps
    {
        private IWebDriver _driver;
        [Given(@"I have navigated to the Planit home webpage")]
        public void GivenIHaveNavigatedToThePlanitHomeWebpage()
        {
            _driver = new ChromeDriver(@"C:\Users\kmaisuria\Documents");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.planittesting.com/nz/Contact");
            Assert.AreEqual("Planit - Contact Planit: The Leaders in Quality Engineering", _driver.Title);
        }
        
        [Given(@"I have clicked on Contact Us")]
        public void GivenIHaveClickedOnContactUs()
        {
            IWebElement firstName = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));
        }
        
        [Given(@"I have entered (.*) into firstname")]
        public void GivenIHaveEnteredKrishIntoFirstname(string firstName)
        {
            IWebElement firstName1 = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));
            firstName1.SendKeys(firstName);
           
        }
        
        [Given(@"I have entered (.*) into lastname")]
        public void GivenIHaveEnteredBrooIntoLastname(string lastName)
        {
            IWebElement lastname = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText"));
            lastname.SendKeys(lastName);
        }
        
        [When(@"I press Submit")]
        public void WhenIPressSubmit()
        {
            IWebElement submit = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK"));
            submit.Click();
            
        }
        
        [Then(@"the result should display a error")]
        public void ThenTheResultShouldDisplayAError()
        {
            string NoJobTitle = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Text;
            Assert.AreEqual("Please enter your job title", NoJobTitle);
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
