using Microsoft.VisualBasic.FileIO;
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
using Baigiamasis_darbas.Pages;
using Baigiamasis_darbas.Page;

namespace Baigiamasis_darbas.Pages
{
    class IdealGiftPages : IdealBasePage
    {

        private const string PageAddress = "https://www.ideal.lt/dovanu-kuponas";

        private SelectElement _singleDropDown => new SelectElement(Driver.FindElement(By.Id("card-amount")));
        private IWebElement _resultTextElement => Driver.FindElement(By.CssSelector("//*[@id=\"card-amount\"]/option[5]"));
        private IWebElement _getFirstSelectedButton => Driver.FindElement(By.CssSelector("//*[@id=\"product_addtocart_form\"]/div[3]/div/div[2]/a[2]"));
        private IWebElement _addToWallet => Driver.FindElement(By.CssSelector(".product__submit"));
        private IWebElement _viewWallet => Driver.FindElement(By.ClassName("drop-basket__view c-btn c-btn--arrow no-reg-btn js-act c-btn--full is-click"));

        public IdealGiftPages(IWebDriver webDriver) : base(webDriver) { }

        public IdealGiftPages NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public IdealGiftPages SelectDropDownByValue(string value)
        {
            _singleDropDown.SelectByValue(value);

            return this;
        }

        public IdealGiftPages SelectDropDownByText()
        {
            _getFirstSelectedButton.Click();

            return this;
        }

        public IdealGiftPages ProductToWallet()
        {
            _addToWallet.Click();

            return this;
        }

        public IdealGiftPages ProductWallet(string result)
        {
           
            Assert.AreEqual($"Rasta:{result}", _viewWallet.Text, "Nieko nerasta");

            return this;
        }
    }
}

