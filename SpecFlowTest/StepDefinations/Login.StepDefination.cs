using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SpecFlowTest.Helpers;

namespace SpecFlowTest.StepDefinations
{
   public partial class StepDefinations
    {

        private string _appUrl;
        [Given(@"I have '(.*)' opened")]
        public void GivenIHaveOpened(string url)
        {
            _appUrl = ConfigSettings.GetKeyValue(url);
        }

       [When(@"'(.*)' is logged in")]
        public void WhenIsLoggedIn(string uid)
       {
           var userId = ConfigSettings.GetKeyValue(uid);
           ScenarioContext.Current.Add("UserId",userId);
           DoLogin(_appUrl, userId, userId);
        }

        [Then(@"PageTitle should be '(.*)'")]
        public void ThenPageTitleShouldBe(string p0)
        {
            Assert.AreEqual("Home", _driver.Title);
            
        }

        [Then(@"only valid widgets should be visible")]
        public void ThenOnlyValidWidgetsShouldBeVisible()
        {
            var userId = ScenarioContext.Current.Get<string>("UserId");
            var validWidgets = ConfigSettings.GetKeyValue(string.Concat(userId, "_Widgets"));
            var widgetsList = validWidgets.Split(';').ToList<string>();
            var availableWidgets = _homePage.GetAllAvailableWidgets();
            if(widgetsList.Count!=availableWidgets.Count)
                Assert.Fail();

            var difference = widgetsList.Intersect(availableWidgets.Select(s => s.Text)).ToList();
            if (difference.Count == widgetsList.Count)
                Assert.IsTrue(true);
            else
                Assert.Fail();
        }


    }
}
