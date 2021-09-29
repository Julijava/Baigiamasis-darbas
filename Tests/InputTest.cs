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
    public class InputTest : BaseTest
    {
        //public static IWebDriver _driver;

        //[Test]
        //public static void SetUp()
        //{
            //_driver = new ChromeDriver();
            //_driver.Manage().Window.Maximize();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //_driver.Navigate().GoToUrl("https://store.porsche.lt/");
            //_driver.FindElement(By.CssSelector("#cookie-bar > div > span.cookie-bar__buttons > button")).Click();
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            //IWebElement popup = _driver.FindElement(By.CssSelector("body > div.mfp-wrap.mfp-close-btn-in.mfp-auto-cursor.my-mfp-zoom-in.mfp-ready > div > div.mfp-content > div > button"));
            // wait.Until(e => e.FindElement(By.CssSelector("#cookie-bar > div > span.cookie-bar__buttons > button")).Displayed);
            //popup.Click();           
        //}

        //[OneTimeTearDown]
        //public static void TearDown()
        //{
        //    //_driver.Close();
        //}

        [Test]
        [Obsolete]
        public static void TestInputField()
        {
            //InputPage page = new InputPage(Driver);
            string firstValue = "Julija";
            string secondValue = "Ziniene";
            string thirdValue = "varnaite.j@gmail.com";
            string fourthValue = "varnaite.j@gmail.com";
            string fithValue = "12345678";
            string sixthValue = "12345678";

            _inputPage.NavigateToDefaultPage();
            _inputPage.ClickRegistrationButton();
            _inputPage.InsertSixthValuesToInputField(firstValue, secondValue, thirdValue, fourthValue, fithValue, sixthValue);
        }

        [TestCase("Julija", "Ziniene", "varnaite.j@gmail.com", "varnaite.j@gmail.com", "12345678", "12345678", TestName = "Julija, Ziniene, varnaite.j@gmail.com, varnaite.j@gmail.com, 12345678, 12345678")]
        public static void TestRegistration(string firstValue, string secondValue, string thirdValue, string fourthValue, string fithValue, string sixthValue)
        {
            InputPage page = new InputPage(Driver);
            _inputPage.NavigateToDefaultPage();
            _inputPage.ClickRegistrationButton();
            _inputPage.InsertSixthValuesToInputField(firstValue, secondValue, thirdValue, fourthValue, fithValue, sixthValue);
        }

    }
}
