using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Baigiamasis_darbas.Drivers
{
    class CustomDriver
    {
       public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
            
        }

        public static IWebDriver GetChromeDriver()
        {
            return GetDriver(Browsers.Chrome);

        }

        private static IWebDriver GetDriver(Browsers browserName)
        {
            IWebDriver webDriver = null;

            switch(browserName)
            {
                case Browsers.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                case Browsers.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                default:
                    webDriver = new FirefoxDriver();
                    break;
            }
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Manage().Window.Maximize();
            return webDriver;
        }
    }
}

