using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UnitTestProject2
{
    class PrepereForTravel
    {
        static IWebDriver driver;
        private static string url = "https://www.klm.com/home/us/en";
        private static string url2 = "https://shop.klm.com/nl_en/";
        private static readonly By LinqPrepare = By.LinkText("Prepare for travel");
        private static readonly By LinqTaxFree = By.PartialLinkText("Tax-free deals");
        private static readonly By ChooseGucci = By.XPath("//*[(text()='GucciBloom EdP 50ml')]");
        private static readonly By AddToBasket = By.XPath("//*[(text()=' Add to shopping basket ')]");
        private static readonly By Shop = By.XPath("//button[@class='shopping-cart-order']");
        private static readonly By CompleteGucci = By.XPath("//div[@class='g-grid--span12 step-title']");

        public static IWebDriver Instance()
        {
            driver = new ChromeDriver(@"D:\old\Епам\chromedriver_win32");
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void URL()
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void URL2()
        {
            driver.Navigate().GoToUrl(url2);
        }

        public static void ChooseThings()
        {
           
            Thread.Sleep(30000);
            IWebElement Gucci = driver.FindElement(ChooseGucci);
            Thread.Sleep(5000);
            Gucci.Click();
            Thread.Sleep(5000);
            IWebElement AddToBascet = driver.FindElement(AddToBasket);
            Thread.Sleep(5000);
            AddToBascet.Click();
            Thread.Sleep(30000);
            IWebElement OrderNaow = driver.FindElement(Shop);
            Thread.Sleep(5000);
            OrderNaow.Click();
            Thread.Sleep(5000);
        }
        public static bool OkGucci
        {
            get { return driver.FindElement(CompleteGucci).Enabled; }
        }
    }

}

