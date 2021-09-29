using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSBaigiamasisDarbas.Page
{
    public class BasePage
    {
            protected static IWebDriver Driver;
            // konstruktorius sukuriamas
            public BasePage(IWebDriver webDriver)
            {
                Driver = webDriver;
            }

            public void CloseBrowser()
            {
                Driver.Quit();
            }
            //sukuriame kita metoda wait'ui

            public WebDriverWait GetWait(int seconds = 5)
            {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            return wait;
            }
    }
}
