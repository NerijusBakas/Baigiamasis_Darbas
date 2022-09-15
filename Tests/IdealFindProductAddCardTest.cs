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
    class IdealFindProductAddCardTest : BaseTest
    {
    

        [Test]
        public void SearchProduct()
        {

            _idealFindProductAddCardPages.NavigateToDefaultPage();
            _idealFindProductAddCardPages.SelectProduct();
            _idealFindProductAddCardPages.ChooseProduct();
            _idealFindProductAddCardPages.AddProductToWallet();
            
        }

    }

}
