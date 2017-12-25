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
    class ChooseTour
    {
        static IWebDriver driver;
        private static string url = "https://www.klm.com/home/us/en";
        private static string url2 = "https://cars.cartrawler.com/klm/en/book?clientId=614739&residencyId=us&pickupIATACode=MSQ&returnIATACode=MSQ&pickupDateTime=2017-12-28T10:00&returnDateTime=2018-01-04T10:00&orderIDExt=LP-ancillary&orderID=us&c=by#/vehicles";
        private static readonly By TourTo = By.ClassName("g-locationpicker--destination");
        private static readonly By TourFrom = By.ClassName("g-search-form--input");
        private static readonly By ButtonViewOffers = By.XPath("//button[@class='g-btn g-btn-primary g-search-form--footer-continue-button']");
        private static readonly By February = By.XPath("//div[@class='bf-fares__fare g-hc-ignore bf-fares__fare--more-month-bars bf-fares__fare--bar bf-fares__fare--bar--lowest bf-non-tabbable']");
        private static readonly By Sun04 = By.XPath("//*[(text()='04 Sun')]");
        private static readonly By ChooseAirTo = By.XPath("//div[@class='bf-flight-overview__flex g-hc-ignore']");
        private static readonly By Web14 = By.XPath("//*[(text()='13 Tue')]");
        private static readonly By ChooseAirFrom = By.XPath("//div[@class='bf-flight-list__item__overview-container g-hc-ignore']");
        private static readonly By ButtonContinue = By.Id("bf-continue-button");
        private static readonly By Email = By.XPath("//button[@class='bf-mail-my-search__open-button bf-button-link']");
        private static readonly By FirstName = By.Id("bf-field-first-name");
        private static readonly By FamilyName = By.Id("bf-field-family-name");
        private static readonly By FieldEmail = By.Id("bf-field-email");
        private static readonly By ButtonEmail = By.XPath("//*[(text()='Mail search details')]");
        private static readonly By OneWay = By.LinkText("One way");
        private static readonly By FebruaryOneWay = By.XPath("//li[@class='est-lane est-barchart-month-02 est-loaded']");
        private static readonly By FebruaryOneWayDay = By.XPath("//li[@id='cb_2579']");
        private static readonly By ChoseTour = By.XPath("//li[@class='est-flight  est-flight-nr-of-stops-1  est-flight-operators-0']");
        private static readonly By ButtonOneWay = By.XPath("//*[(text()='Continue')]");
        private static readonly By IdReturn = By.Id("returnLocation");
        private static readonly By IDButtonCar = By.XPath("//button[@id='searchCarsFormBtn-vehicles']");
        private static readonly By Complete1 = By.Id("ps-page-product-list-booking__product-list__title");
        private static readonly By ErrorToFrom = By.XPath("//p[@class='g-notification-message']");
        private static readonly By CompleteMail = By.ClassName("bf-mail-my-search__content__text");
        private static readonly By CompleteToOneWay = By.Id("ps-page-product-list-booking__product-list__title");
        private static readonly By ErrorCar = By.XPath("//*[(text()=' No results matching your criteria')]");

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

        public static void ChooseTourToFrom(string tourto)
        {

            IWebElement tourtot = driver.FindElement(TourTo);
            Thread.Sleep(500);
            tourtot.SendKeys(tourto);
            Thread.Sleep(500);
            tourtot.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            tourtot.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(ButtonViewOffers).Click();
            Thread.Sleep(10000);
            driver.FindElement(February).Click();
            Thread.Sleep(10000);
            driver.FindElement(Sun04).Click();
            Thread.Sleep(10000);
            driver.FindElement(ChooseAirTo).Click();
            Thread.Sleep(10000);
            driver.FindElement(Web14).Click();
            Thread.Sleep(10000);
            driver.FindElement(ChooseAirFrom).Click();
            Thread.Sleep(60000);
            driver.FindElement(ButtonContinue).Click();
            Thread.Sleep(10000);
        }

        public static void ChooseTourToFromEroor(string tourfrom)
        {
            IWebElement tourfromm = driver.FindElement(TourFrom);
            Thread.Sleep(500);
            tourfromm.SendKeys(tourfrom);
            Thread.Sleep(500);
            tourfromm.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            tourfromm.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(ButtonViewOffers).Click();
        }

        public static void Emaill(string tourto, string firstname, string familyname, string mail)
        {
            IWebElement tourtot = driver.FindElement(TourTo);
            Thread.Sleep(500);
            tourtot.SendKeys(tourto);
            Thread.Sleep(500);
            tourtot.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            tourtot.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(ButtonViewOffers).Click();
            Thread.Sleep(10000);
            driver.FindElement(February).Click();
            Thread.Sleep(10000);
            driver.FindElement(Sun04).Click();
            Thread.Sleep(50000);
            driver.FindElement(ChooseAirTo).Click();
            Thread.Sleep(10000);
            driver.FindElement(Web14).Click();
            Thread.Sleep(10000);
            driver.FindElement(ChooseAirFrom).Click();
            Thread.Sleep(60000);
            driver.FindElement(Email).Click();
            Thread.Sleep(10000);
            IWebElement firtname = driver.FindElement(FirstName);
            Thread.Sleep(10000);
            firtname.SendKeys(firstname);
            Thread.Sleep(10000);
            IWebElement familname = driver.FindElement(FamilyName);
            Thread.Sleep(10000);
            familname.SendKeys(familyname);
            Thread.Sleep(10000);
            IWebElement emailll = driver.FindElement(FieldEmail);
            Thread.Sleep(10000);
            emailll.SendKeys(mail);
            Thread.Sleep(10000);
            IWebElement ButtonMail = driver.FindElement(ButtonEmail);
            Thread.Sleep(10000);
            ButtonMail.Click();
            Thread.Sleep(10000);
        }

        public static void ChooseTourTo(string tourto)
        {
            IWebElement tourtot = driver.FindElement(TourTo);
            Thread.Sleep(500);
            tourtot.SendKeys(tourto);
            Thread.Sleep(500);
            tourtot.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            tourtot.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            IWebElement LinkOneWay = driver.FindElement(OneWay);
            Thread.Sleep(5000);
            LinkOneWay.Click();
            Thread.Sleep(5000);
            IWebElement FebruaryOneway = driver.FindElement(FebruaryOneWay);
            Thread.Sleep(5000);
            FebruaryOneway.Click();
            Thread.Sleep(40000);
            IWebElement FebruaryDay = driver.FindElement(FebruaryOneWayDay);
            Thread.Sleep(40000);
            FebruaryDay.Click();
            Thread.Sleep(40000);
            IWebElement tour = driver.FindElement(ChoseTour);
            Thread.Sleep(5000);
            tour.Click();
            Thread.Sleep(60000);
            driver.FindElement(ButtonOneWay).Click();
            Thread.Sleep(50000);
        }

        public static void ChooseCar(string car)
        {
            Thread.Sleep(50000);
            IWebElement Car = driver.FindElement(IdReturn);
            Thread.Sleep(500);
            Car.SendKeys(car);
            Thread.Sleep(5000);
            Car.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            Car.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(IDButtonCar).Click();
            Thread.Sleep(500);
        }

        public static bool Ok
        {
            get { return driver.FindElement(Complete1).Enabled; }
        }

        public static bool OkMail
        {
            get { return driver.FindElement(CompleteMail).Enabled; }
        }

        public static bool OkToOneWay
        {
            get { return driver.FindElement(CompleteToOneWay).Enabled; }
        }

        public static string ErrorTourToFrom
        {
            get { return driver.FindElement(ErrorToFrom).Text; }
        }

        public static string ErrorCarr
        {
            get { return driver.FindElement(ErrorCar).Text; }
        }
    }
}
