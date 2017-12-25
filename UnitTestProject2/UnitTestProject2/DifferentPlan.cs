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
    class DifferentPlan
    {
        static IWebDriver driver;
        private static string url = "https://www.klm.com/home/us/en";
        private static string url2 = "https://cars.cartrawler.com/klm/en?clientId=614756&residencyId=us&pickupIATACode=MSQ&returnIATACode=MSQ&pickupDateTime=2017-12-28T10:00&returnDateTime=2017-12-28T11:00&orderIDExt=LP-ancillary&orderID=us&taxi=1&c=by#/search";
        private static readonly By LinqPlananqBooks = By.LinkText("Plan and Book");
        private static readonly By LinqHotel = By.PartialLinkText("Hotels");
        private static readonly By LinqAccommodation = By.LinkText("Accommodation via Airbnb");
        private static readonly By FielDestination = By.Id("airbnb-destination-picker");
        private static readonly By ShowOptions = By.ClassName("airbnbButton");
        private static readonly By RentCar = By.LinkText("Rent a car");
        private static readonly By FieldCarPicUp = By.Id("car-origin-picker");
        private static readonly By FieldCarDropOff = By.Id("car-destination-picker");
        private static readonly By ButtonCar = By.ClassName("carCrawlerButton");
        private static readonly By LinqTransfer = By.LinkText("Airport transfer");
        private static readonly By FieldTransfer = By.Id("gt-pick-up-picker");
        private static readonly By ButtonTransfer = By.ClassName("groundTransportButton");
        private static readonly By FieldTransferUp = By.Id("input-pickup");
        private static readonly By ButtonSearch = By.XPath("//button[@class='ct-btn ct-btn-p']");
        private static readonly By LinqActivities = By.LinkText("Tours & Activities");
        private static readonly By FieldActivities = By.Id("car-origin-getyourguide");
        private static readonly By ButtonActivities = By.ClassName("getyourguideButton");
        private static readonly By FieldAirbnb = By.Id("car-origin-bookingcom");
        private static readonly By ButtonAirbnb = By.ClassName("bookingComButton");
        private static readonly By CompleteTransfer = By.ClassName("ct-active");

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

        public static void PlanAccommodaion()
        {
            driver.FindElement(LinqPlananqBooks).Click();
            driver.FindElement(LinqHotel).Click();
            driver.FindElement(LinqAccommodation).Click();
            IWebElement field = driver.FindElement(FielDestination);
            Thread.Sleep(500);
            field.SendKeys("Amsterdam");
            Thread.Sleep(500);
            field.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            field.SendKeys(Keys.Enter);
            Thread.Sleep(500);
            driver.FindElement(ShowOptions).Click();
        }

        public static void ChooseCar()
        {
            //driver.FindElement(LinqPlananqBooks).Click();
            //driver.FindElement(LinqHotel).Click();
            //driver.FindElement(RentCar).Click();
            IWebElement FiedlUp = driver.FindElement(FieldCarPicUp);
            Thread.Sleep(500);
            FiedlUp.SendKeys("Minsk");
            Thread.Sleep(500);
            FiedlUp.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            FiedlUp.SendKeys(Keys.Enter);
            Thread.Sleep(500);
            IWebElement FieldOff = driver.FindElement(FieldCarDropOff);
            Thread.Sleep(500);
            FieldOff.SendKeys("Minsk");
            Thread.Sleep(500);
            FieldOff.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            FieldOff.SendKeys(Keys.Enter);
            Thread.Sleep(500);
            driver.FindElement(ButtonCar).Click();
        }

        public static void Transfer()
        {
            Thread.Sleep(50000);
            IWebElement fieldtransferup = driver.FindElement(FieldTransferUp);
            fieldtransferup.SendKeys("Minsk");
            Thread.Sleep(5000);
            fieldtransferup.SendKeys(Keys.ArrowDown);
            Thread.Sleep(5000);
            fieldtransferup.SendKeys(Keys.Enter);
            Thread.Sleep(50000);
            IWebElement po = driver.FindElement(ButtonSearch);
            Thread.Sleep(5000);
            po.Click();
        }

        public static void Activities()
        {
            driver.FindElement(LinqPlananqBooks).Click();
            driver.FindElement(LinqHotel).Click();
            driver.FindElement(LinqActivities).Click();
            IWebElement fieldactivities = driver.FindElement(FieldActivities);
            Thread.Sleep(5000);
            fieldactivities.SendKeys("Amsterdam");
            Thread.Sleep(5000);
            fieldactivities.SendKeys(Keys.ArrowDown);
            Thread.Sleep(5000);
            fieldactivities.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(ButtonActivities).Click();
        }

        public static void Airbnb()
        {
            driver.FindElement(LinqPlananqBooks).Click();
            driver.FindElement(LinqHotel).Click();
            IWebElement fieldairbnb = driver.FindElement(FieldAirbnb);
            Thread.Sleep(5000);
            fieldairbnb.SendKeys("Amsterdam");
            Thread.Sleep(5000);
            fieldairbnb.SendKeys(Keys.ArrowDown);
            Thread.Sleep(5000);
            fieldairbnb.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(ButtonAirbnb).Click();
        }

        public static bool OkTransfer
        {
            get { return driver.FindElement(CompleteTransfer).Enabled; }
        }


    }
}
