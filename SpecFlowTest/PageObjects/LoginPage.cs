using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTest.PageObjects
{
    class LoginPage:Page
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
