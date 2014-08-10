using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SpecFlowTest.PageObjects
{
    public class PreferencesPage : Page
    {
        public PreferencesPage(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement ModifyButton
        {
            get
            {
                return
                    _driver.FindElement(
                        By.XPath("/html/body/div[2]/div[1]/div/div[1]/div/form/section[2]/div/div/div/button"));
            }
        }

        public SelectElement LanguageDropdown
        {
            get
            {
                return new SelectElement(_driver.FindElement(By.Id("LANGUAGE")));

            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return
                    _driver.FindElement(
                        By.XPath("//*[@id='preferencesModal']/div/div/div[3]/button[1]"));
            }
        }

        public IWebElement PreferenePageText
        {
            get
            {
                return _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div[1]/div/section[1]/div/h1/span"));
            }
        }

    }
}
