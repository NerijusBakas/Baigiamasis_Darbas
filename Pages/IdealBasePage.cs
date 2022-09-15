using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Baigiamasis_darbas.Page
{
    class IdealBasePage
    {
        protected static IWebDriver Driver;

        public IdealBasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
        }
    }
}