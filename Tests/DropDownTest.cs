using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSBaigiamasisDarbas.Page;

namespace VCSBaigiamasisDarbas.Tests
{
    public class DropDownTest : BaseTest
    {
        //private static DropDownPage _page;
        //private static IWebDriver _driver;

        //[OneTimeSetUp]
        //public void SetUp()
        //{
        //    _driver = new ChromeDriver();
        //    _driver.Manage().Window.Maximize();
        //    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    //_driver.FindElement(By.CssSelector("body > div.mfp-wrap.mfp-close-btn-in.mfp-auto-cursor.my-mfp-zoom-in.mfp-ready > div > div.mfp-content > div > button")).Click();

        //    //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        //    _page = new DropDownPage(_driver);
        //}

        //[OneTimeTearDown]
        //public static void TearDown()
        //{
        //    //_driver.Close();
        //}

        [Test]
        public void TestDropDown()
        {
            _dropDownPage.NavigateToDefaultPage()
                .SelectFromDropDrownByClassName("m-14-image-wrapper")
                .VerifyResult("m-14-image-wrapper");
        }
    }
}
