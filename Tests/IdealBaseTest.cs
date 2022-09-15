using Baigiamasis_darbas.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;
using Baigiamasis_darbas.Tools;
using Baigiamasis_darbas.Drivers;

namespace Baigiamasis_darbas.Tests
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static IdealSearchPage _idealSearchPage;
        public static IdealSearchMacAndAddToWalletPages _idealSearchMacAndAddToWalletPages;
        public static IdealGiftPages _idealGiftPages;
        public static IdealFindProductAddCardPages _idealFindProductAddCardPages;
        public static IdealSearchIphonePage _idealSearchIphonePage;
        public static IdealSearchMacAndAddToWalletPages idealSearchMacAndAddToWalletPages;



        [OneTimeSetUp]
        public static void Setup()
        {

            Driver = CustomDriver.GetFirefoxDriver();
           

            _idealSearchPage = new IdealSearchPage(Driver);
            _idealGiftPages = new IdealGiftPages(Driver);
            _idealFindProductAddCardPages = new IdealFindProductAddCardPages(Driver);
            _idealSearchIphonePage = new IdealSearchIphonePage(Driver);
            _idealSearchMacAndAddToWalletPages = new IdealSearchMacAndAddToWalletPages(Driver);

        }
            

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenShot.TakeScreenshot(Driver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
           Driver.Close();
        }
    }
}