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
    public class FirstTest
    {
        public static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.porsche.lt/lt");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.CssSelector("body > div.mfp-wrap.mfp-close-btn-in.mfp-auto-cursor.my-mfp-zoom-in.mfp-ready > div > div.mfp-content > div > button")).Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public static void TearDown()
        {
        // _driver.Quit();
        }

        [Test] 
        public static void TestPorchePage()
        {
            IWebElement susikurkiteButton = _driver.FindElement(By.CssSelector("#about > svg"));
            susikurkiteButton.Click();

            IWebElement modeliaiButton = _driver.FindElement(By.Id("select2-chosen-1"));
            modeliaiButton.Click();

            IWebElement selectButton = _driver.FindElement(By.CssSelector("#select2-results-1 > li:nth-child(4)"));
            selectButton.Click();

            IWebElement selectCarButton = _driver.FindElement(By.Id("s_model_selection_x_911_x__992440NC13"));
            selectCarButton.Click();

            IWebElement select2Button = _driver.FindElement(By.CssSelector("#s_exterieur_x_FP3 > span"));
            //IWebElement select2Button = _driver.FindElement(By.CssSelector("#s_exterieur_x_F0L > span"));
            
            select2Button.Click();

            IWebElement select3Button = _driver.FindElement(By.Id("IAF_subHdl"));
            select3Button.Click();

            IWebElement select4Button = _driver.FindElement(By.Id("IRA_subHdl"));
            select4Button.Click();
            
            IWebElement select5Button = _driver.FindElement(By.Id("IRZ_subHdl"));
            select5Button.Click();

            IWebElement checkBox = _driver.FindElement(By.Id("vs_table_IRZ_x_M1G8_x_c11_M1G8"));
            checkBox.Click();

            IWebElement chairButton = _driver.FindElement(By.Id("submenu_seats_subHdl"));
            chairButton.Click();

            //IWebElement checkBoxResult = _driver.FindElement(By.ClassName("cca-price"));
            //Assert.IsTrue(checkBoxResult.Text.Contains("60,00€"));
        }
    }
}
