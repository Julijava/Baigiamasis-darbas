using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace VCSBaigiamasisDarbas
{
    public class ThirdTest
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
              // _driver.Quit();
            }

        [Test]
        public static void TestRegistrationPage()
        {
            IWebElement registrationButton = _driver.FindElement(By.CssSelector("#top > div.page-wrap > div.fixed-header > header > div > div > div.header__nav > div.header__nav__inner > nav:nth-child(2) > div:nth-child(3) > a"));
            registrationButton.Click();

            IWebElement firstNameInput = _driver.FindElement(By.Id("frm-registerControl-createForm-firstName"));
            firstNameInput.Clear();
            firstNameInput.Click();
            firstNameInput.SendKeys("Julija");

            IWebElement lastNameInput = _driver.FindElement(By.Id("frm-registerControl-createForm-lastName"));
            lastNameInput.Clear();
            lastNameInput.Click();
            lastNameInput.SendKeys("Ziniene");

            IWebElement emailInput = _driver.FindElement(By.Id("frm-registerControl-createForm-email"));
            emailInput.Clear();
            emailInput.Click();
            emailInput.SendKeys("varnaite.j@gmail.com");

            IWebElement email2Input = _driver.FindElement(By.Id("frm-registerControl-createForm-email2"));
            email2Input.Clear();
            email2Input.Click();
            email2Input.SendKeys("varnaite.j@gmail.com");

            IWebElement passInput = _driver.FindElement(By.Id("frm-registerControl-createForm-userPass"));
            passInput.Clear();
            passInput.Click();
            passInput.SendKeys("12345678");

            IWebElement pass2Input = _driver.FindElement(By.Id("frm-registerControl-createForm-userPass2"));
            pass2Input.Clear();
            pass2Input.Click();
            pass2Input.SendKeys("12345678");

            //IWebElement pseudoEle = _driver.FindElement(System.IO.Path);
            //string display = ((JavascriptExecutor)getWebDriver()).executeScript("return window.getComputedStyle(arguments[0], ':after').getPropertyValue('display');", pseudoEle).toString();

            //IReadOnlyCollection<IWebElement> multipleCheckBoxes = _driver.FindElements(By.ClassName("form-group required Mt(1.125rem)"));

            //foreach (IWebElement checkBox in multipleCheckBoxes)
            //{
            //    checkBox.Click();
            //}
        }
    }
}
        
    


