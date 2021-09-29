using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSBaigiamasisDarbas.Page
{
    public class DropDownPage : BasePage
    {
        private const string PageAddress = "https://www.porsche.lt/lt/models/911/";
        private const string ResultTextStatic = "Modeliai";
        private SelectElement _dropDown => new SelectElement(Driver.FindElement(By.ClassName("m-14-model-series-divider visible")));
       

        IWebElement _resultText => Driver.FindElement(By.CssSelector("#m992410 > a > div.m-14-image-wrapper"));
        public DropDownPage(IWebDriver webDriver) : base(webDriver) { }

        public InputPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;

            }
            return this;
        }
        public DropDownPage SelectFromDropDrownByText(string text)
        {
            _dropDown.SelectByText(text);

            return this;
        }

        public DropDownPage SelectFromDropDrownByClassName(string text)
        {
            _dropDown.SelectByValue(text);

            return this;
        }

        public DropDownPage VerifyResult(string expectedResult)
        {
            Assert.AreEqual(ResultTextStatic + expectedResult, _resultText.Text, $"Result is wrong, not {expectedResult}");
            return this;
        }
    }
}
