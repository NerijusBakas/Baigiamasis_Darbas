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
    class IdealSearchMacAndAddToWalletPages : IdealBasePage
    {
        private const string PageAddress = "https://www.ideal.lt";
        private const string value = "Macbook";

        private IWebElement _SearchField => Driver.FindElement(By.CssSelector("span.sprite"));
        private IWebElement _InsertText => Driver.FindElement(By.Id("search"));
        private IWebElement _ClickSearchButton => Driver.FindElement(By.ClassName("top-search__submit"));
        private IWebElement _ChooseProduct => Driver.FindElement(By.Id("product-image-9113"));
        private IWebElement _AddToWallet => Driver.FindElement(By.CssSelector("a.product__submit:nth-child(3)"));
      
     
        public IdealSearchMacAndAddToWalletPages(IWebDriver webDriver) : base(webDriver) { }

        public IdealSearchMacAndAddToWalletPages NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }


        public IdealSearchMacAndAddToWalletPages SearchField()
        {
            _SearchField.Click();

            return this;

        }


        public IdealSearchMacAndAddToWalletPages InsertText(string value)
        {
            _InsertText.Clear();
            _InsertText.SendKeys(value);

            return this;
        }



        public IdealSearchMacAndAddToWalletPages ClickSubmitButton()
        {
            _ClickSearchButton.Click();

            return this;
        }

        public IdealSearchMacAndAddToWalletPages ChooseProduct()
        {
            _ChooseProduct.Click();

            return this;
        }

        public IdealSearchMacAndAddToWalletPages AddToWallet()
        {
            _AddToWallet.Click();

            return this;

        }


    }
}

