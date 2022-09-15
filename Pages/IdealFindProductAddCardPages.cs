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
    class IdealFindProductAddCardPages : IdealBasePage
    {

        private const string PageAddress = "https://www.ideal.lt/airpods";

        private IWebElement _SearchProduct => Driver.FindElement(By.ClassName("category-block__meta"));
        private IWebElement _SelectProduct => Driver.FindElement(By.ClassName("products-item__text"));
        private IWebElement _ToWalletAdd => Driver.FindElement(By.CssSelector(".product__submit"));
    
       
        public IdealFindProductAddCardPages(IWebDriver webDriver) : base(webDriver) { }

        public IdealFindProductAddCardPages NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public IdealFindProductAddCardPages SelectProduct()
        {
            _SearchProduct.Click();

            return this;
         
        }


        public IdealFindProductAddCardPages ChooseProduct()
        {
            _SelectProduct.Click();

            return this;

        }


        public IdealFindProductAddCardPages AddProductToWallet()
        {
            _ToWalletAdd.Click();

            return this;
        }


        
        
    }
}

