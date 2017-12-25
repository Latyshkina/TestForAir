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
    class Ask
    {
        static IWebDriver driver;
        private static string url = "https://www.klm.com/home/us/en";
        private static readonly By ButtonFind = By.ClassName("js-sa-query-submit");
        private static readonly By LinqQuestion = By.LinkText("How much baggage can I bring?");
        private static readonly By LinqQuestion2 = By.LinkText("Children's baggage");
        private static readonly By LinqQuestion3 = By.LinkText("Under 2 on parent's lap");
        private static readonly By FieldFind = By.ClassName("js-sa-query-input");
        private static readonly By CompleteAsk = By.Id("sa-answer");
        private static readonly By Error = By.Id("sa-answer");

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

        public static void AskTemplate()
        {
            driver.FindElement(ButtonFind).Click();
            Thread.Sleep(2000);
            driver.FindElement(LinqQuestion).Click();
            Thread.Sleep(2000);
            driver.FindElement(LinqQuestion2).Click();
            Thread.Sleep(2000);
            driver.FindElement(LinqQuestion3).Click();
        }

        public static void AskYou()
        {
            IWebElement po = driver.FindElement(FieldFind);
            Thread.Sleep(10000);
            po.SendKeys("gcjcgk");
            Thread.Sleep(2000);
            driver.FindElement(ButtonFind).Click();

        }
        public static bool OkAsk
        {
            get { return driver.FindElement(CompleteAsk).Enabled; }
        }
        public static string ErrorAsk
        {
            get { return driver.FindElement(Error).Text; }
        }
    }
}
