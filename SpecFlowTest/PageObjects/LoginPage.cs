using OpenQA.Selenium;

namespace SpecFlowTest.PageObjects
{
    public class LoginPage:Page
    {
        public LoginPage(IWebDriver driver) 
            : base(driver)
        {
        }
        public IWebElement UserID
        {
            get
            {
                return _driver.FindElement(By.Name("j_username"));
            }
        }

        public IWebElement Password
        {
            get
            {
                return _driver.FindElement(By.Name("j_password"));
            }
        }

        public IWebElement ButtonOK
        {
            get
            {
                return _driver.FindElement(By.ClassName("applet-btn-ok"));
            }
        }
    }
}
