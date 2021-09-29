using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSBaigiamasisDarbas.Drivers;
using VCSBaigiamasisDarbas.Page;

namespace VCSBaigiamasisDarbas.Tests
{
    public class BaseTest
    {
        protected static IWebDriver Driver;
        public static DropDownPage _dropDownPage;
        public static InputPage _inputPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetIncognitoChromeDriver();
            _dropDownPage = new DropDownPage(Driver);
            _inputPage = new InputPage(Driver);
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }


        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Close();
        }
    }
}
