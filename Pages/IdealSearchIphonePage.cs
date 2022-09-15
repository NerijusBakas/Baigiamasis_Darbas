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

namespace Baigiamasis_darbas.Pages
{
     class IdealSearchIphonePage : IdealBasePage
    {
        private const string PageAddress = "https://www.ideal.lt";
        private const string value = "Iphone";

        private IWebElement _SearchField => Driver.FindElement(By.CssSelector("span.sprite"));
        private IWebElement _InsertText => Driver.FindElement(By.Id("search"));
        private IWebElement _ClickSearchButton => Driver.FindElement(By.ClassName("top-search__submit"));
        private IWebElement _Result => Driver.FindElement(By.ClassName("u-wrap u-clear"));

        public IdealSearchIphonePage(IWebDriver webDriver) : base(webDriver) { }


        public IdealSearchIphonePage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }


        public IdealSearchIphonePage SearchField()
        {
            _SearchField.Click();

            return this;

        }


        public IdealSearchIphonePage InsertText(string value)
        {
            _InsertText.Clear();
            _InsertText.SendKeys(value);

            return this;
        }

        public IdealSearchIphonePage ClickSubmitButton()
        {
            _ClickSearchButton.Click();

            return this;
        }

        public IdealSearchIphonePage ResultInformation(string value)
        {
            Assert.AreEqual($"Rasta:{value}", _Result.Text, "Nieko nerasta");

            return this;
        }

    }
}

