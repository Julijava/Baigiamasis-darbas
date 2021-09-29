using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSBaigiamasisDarbas
{
    public class SecondTest
    {
        public static IWebDriver _driver;

        [OneTimeSetUp]
        [Test]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://store.porsche.lt/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.CssSelector("#cookie-bar > div > span.cookie-bar__buttons > button")).Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]
        public static void TestEStorePage()
        {
            IWebElement eStoreButton = _driver.FindElement(By.CssSelector("#top > div.page-wrap > div.fixed-header > header > div > div > div.header__nav > div.header__nav__inner > nav:nth-child(1) > div:nth-child(5)"));
            eStoreButton.Click();

            IWebElement eStore1Button = _driver.FindElement(By.CssSelector("#top > div > div.container > div > div:nth-child(2) > div > a > div > picture"));
            eStore1Button.Click();

            IWebElement eStore2Button = _driver.FindElement(By.CssSelector("#frm-addToCart-baseForm > div.product-detail__actions > button"));
            eStore2Button.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement eStore3Button = _driver.FindElement(By.CssSelector("#snippet--cart > a > span.icon-box.icon-box--fullwidth"));
            eStore3Button.Click();

            IWebElement eStore4Button = _driver.FindElement(By.CssSelector("#top > div > div.container > div.row > div.col.col--lgUp.col--cart-content > div.form-actions.form-actions--reverse > a.btn.btn-secondary.btn-icon-left"));
            eStore4Button.Click();

            IWebElement testiBeRegistracijosButton = _driver.FindElement(By.CssSelector("#top > div > div.container.checkout-login > div.row.checkout-login__grid.ie-flexbox-height-fix > div:nth-child(2) > a"));
            testiBeRegistracijosButton.Click();




        }
    }
}
