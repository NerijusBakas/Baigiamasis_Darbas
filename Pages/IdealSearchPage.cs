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
    class IdealSearchPage : IdealBasePage
    {
        private const string PageAddress = "https://www.ideal.lt";
        private const string value = "samsung";

        private IWebElement _SearchField => Driver.FindElement(By.CssSelector("span.sprite"));
        private IWebElement _InsertText => Driver.FindElement(By.Id("search"));
        private IWebElement _ClickSearchButton => Driver.FindElement(By.ClassName("top-search__submit"));
        private IWebElement _Result => Driver.FindElement(By.ClassName("note-msgs"));

       
        public IdealSearchPage(IWebDriver webDriver) : base(webDriver) { }

        public IdealSearchPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

     
        public IdealSearchPage SearchField()
        {
            _SearchField.Click();

            return this;

        }


        public IdealSearchPage InsertText(string value)
        {
            _InsertText.Clear();
            _InsertText.SendKeys(value);

            return this;
        }

       

        public IdealSearchPage ClickSubmitButton()
        {
            _ClickSearchButton.Click();

            return this;
        }

        public IdealSearchPage ResultInformation(string expectedResult)
        {
            Assert.AreEqual($"Rasta:{expectedResult}", _Result.Text, "Nieko nerasta");

            return this;
        }

     
    }
}

