using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class TestClickMainPoints
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:5965/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheClickMainPointsTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("12 Main Points of the Book")).Click();
            new SelectElement(driver.FindElement(By.Id("MainContent_ddlMainPoint"))).SelectByText("Sharing spiritual intimacy");
            driver.FindElement(By.CssSelector("option[value=\"4\"]")).Click();
            new SelectElement(driver.FindElement(By.Id("MainContent_ddlMainPoint"))).SelectByText("Leaving and cleaving");
            driver.FindElement(By.CssSelector("option[value=\"1\"]")).Click();
            new SelectElement(driver.FindElement(By.Id("MainContent_ddlMainPoint"))).SelectByText("Sharing responsibility as a team");
            driver.FindElement(By.CssSelector("option[value=\"10\"]")).Click();
            new SelectElement(driver.FindElement(By.Id("MainContent_ddlMainPoint"))).SelectByText("Select One");
            driver.FindElement(By.CssSelector("option[value=\"0\"]")).Click();
            driver.FindElement(By.LinkText("Home")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
