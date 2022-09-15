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
using Baigiamasis_darbas.Tests;
using Baigiamasis_darbas.Page;


namespace Baigiamasis_darbas.Tests
{
    class IdealSearchIphoneTests : BaseTest
    {


        [Test]
        public static void IdealSearchIphone()
        {

            string value = "iphone";

            _idealSearchIphonePage.NavigateToDefaultPage();
            _idealSearchIphonePage.SearchField();
            _idealSearchIphonePage.InsertText(value);
            _idealSearchIphonePage.ClickSubmitButton();
            _idealSearchIphonePage.ResultInformation(value);
        }



    }
}

