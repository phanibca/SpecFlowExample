using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;


namespace SpecFlowTest.PageObjects
{
    public class Page
    {
        protected readonly IWebDriver _driver;

        public Page(IWebDriver driver)
        {
            _driver = driver;
        }
     }
}
