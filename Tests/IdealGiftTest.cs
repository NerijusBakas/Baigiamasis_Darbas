using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Baigiamasis_darbas.Pages;
using Baigiamasis_darbas.Page;

namespace Baigiamasis_darbas.Tests
{
    class IdealGiftTest : BaseTest

    {
        
        
        [Test]
        public void TestSingleDropDown()
        {
            _idealGiftPages.NavigateToDefaultPage();
            _idealGiftPages.SelectDropDownByValue("1000");
            _idealGiftPages.SelectDropDownByText();
            _idealGiftPages.ProductToWallet();
            _idealGiftPages.ProductWallet("1000");

        }

    }
}
