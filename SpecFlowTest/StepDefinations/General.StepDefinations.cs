using System;
using System.Threading;
using SpecFlowTest.Helpers;
using SpecFlowTest.PageObjects;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SpecFlowTest.StepDefinations
{
    [Binding]
    public partial class StepDefinations
    {
        protected IWebDriver _driver;


        #region before/after scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new FirefoxDriver();
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

        public LoginPage _loginPage
        {
            get
            {
                return new LoginPage(_driver);
            }
        }

        public HomePage _homePage
        {
            get
            {
                return new HomePage(_driver);
            }
        }


        public PreferencesPage _preferencesPage
        {
            get
            {
                return new PreferencesPage(_driver);
            }
        }

        [Given(@"I have logged into '(.*)' with '(.*)'")]
        public void GivenIHaveLoggedIntoWith(string appUrl, string appUser)
        {
            var _appUrl = ConfigSettings.GetKeyValue(appUrl);
            var _uid = ConfigSettings.GetKeyValue(appUser);
            DoLogin(_appUrl, _uid, _uid);
        }


        public void DoLogin(string appUrl, string uid, string password)
        {
            _driver.Navigate().GoToUrl(appUrl);
            _loginPage.UserID.SendKeys(uid);
            _loginPage.Password.SendKeys(password);
            _loginPage.ButtonOK.Click();
            Thread.Sleep(1000);

        }

    }
}
