using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SpecFlowTest.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinations
{
    [Binding]
    public class LoginSteps
    {

        protected IWebDriver _driver;

        #region properties

        LoginPage LoginPage
        {
            get
            {
                return new LoginPage(_driver);
            }
        }

        #endregion

        #region before/after scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new  FirefoxDriver();
            //_driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(16));
            _driver.Manage().Window.Maximize();
        }




        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Close();
            _driver.Dispose();
        }
        #endregion

        [Given(@"I have the url '(.*)' opened")]
        public void GivenIHaveTheUrlOpened(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [When(@"'(.*)' is logged in")]
        public void WhenIsLoggedIn(string uid)
        {
            LoginPage.UserID.SendKeys(uid);
            LoginPage.Password.SendKeys(uid);
            LoginPage.ButtonOK.Click();
            Thread.Sleep(1000);
        }

        [Then(@"PageTitle should be '(.*)'")]
        public void ThenPageTitleShouldBe(string p0)
        {
            Assert.AreEqual("Home", _driver.Title);
            
        }
    }
}
