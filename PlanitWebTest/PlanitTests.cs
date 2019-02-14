using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitWebTest
{
    public class PlanitTests
    {
        //[Test]
        public void startApplication()
        {
            using (ChromeDriver driver = new ChromeDriver(@"C:\Users\kmaisuria\Documents"))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.planittesting.com/nz");
                IWebElement contactUs = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl02_PlanIt_ContactUsATag"));
                contactUs.Click();
                Assert.AreEqual("Planit - Contact Planit: The Leaders in Quality Engineering", driver.Title);
            }
        }
        //[Test]
        public void SubmitButton()
        {
            using (ChromeDriver driver = new ChromeDriver(@"C:\Users\kmaisuria\Documents"))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.planittesting.com/nz/Contact");
                IWebElement firstName = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));
                firstName.SendKeys("Krish");
                IWebElement lastname = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText"));
                lastname.SendKeys("Broooooooooo");
                IWebElement submit = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK"));
                submit.Click();
                string NoJobTitle = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Text;
                Assert.AreEqual("Please enter your job title", NoJobTitle);
            }

        }
    }
}
