using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSBaigiamasisDarbas.Drivers
{
    public class CustomDriver
    {
        private static ChromeDriver webDriver;

        public static IWebDriver GetChromDriver()
        {
            return GetDriver(Browsers.Chrome);
        }
        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }

        public static IWebDriver GetIncognitoChromeDriver()
        {
            return GetDriver(Browsers.IncognitoChrome);
        }

        private static IWebDriver GetDriver(Browsers browserName)
        {
            IWebDriver driver = null;
            switch(browserName)
            {
                case Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browsers.IncognitoChrome:
                    driver = GetChromeWithIncognitoOption();
                    break;
                case Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return driver;
        }
        private static IWebDriver GetChromeWithIncognitoOption()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("incognito");
            options.AddArguments("incognito", "start-maximazed");
            return new ChromeDriver(options);
        }
    }
}
