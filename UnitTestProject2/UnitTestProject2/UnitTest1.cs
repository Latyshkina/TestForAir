using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Interactions;
using Microsoft.Win32;
using System.Threading;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;


namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        static IWebDriver driver;

       
        [TestMethod]
        public void ChooseTourToFrom()
        {
            ChooseTour.Instance();
            ChooseTour.URL();
            ChooseTour.ChooseTourToFrom("Minsk");
            Thread.Sleep(10000);
            Assert.IsTrue(ChooseTour.Ok);
        }

        [TestMethod]
        public void ChooseTourToFromEror()
        {
            ChooseTour.Instance();
            ChooseTour.URL();
            ChooseTour.ChooseTourToFromEroor("Minsk");
            Thread.Sleep(10000);
            Assert.AreEqual("Please enter a departure and destination location.", ChooseTour.ErrorTourToFrom);
        }

        [TestMethod]
        public void ChooseTourToFromMali()
        {
            ChooseTour.Instance();
            ChooseTour.URL();
            ChooseTour.Emaill("Minsk", "Katy", "Latyshkina", "ialinloveyou01@gmail.com");
            Assert.IsTrue(ChooseTour.OkMail);
        }


        [TestMethod]
        public void ChooseTourToFromMailEroor()
        {
            ChooseTour.Instance();
            ChooseTour.URL();
            ChooseTour.Emaill("Minsk", "Katy", "Latyshkina", "ialinloveyou0gmailcom");
        }

        [TestMethod]
        public void ChooseTourToOneWay()
        {
            ChooseTour.Instance();
            ChooseTour.URL();
            ChooseTour.ChooseTourTo("Minsk");
            Assert.IsTrue(ChooseTour.OkToOneWay);
        }

        [TestMethod]
        public void PlanAccomudatio()
        {
            DifferentPlan.Instance();
            DifferentPlan.URL();
            DifferentPlan.PlanAccommodaion();
        }

        [TestMethod]
        public void AirportTransfer()
        {
            DifferentPlan.Instance();
            DifferentPlan.URL2();
            DifferentPlan.Transfer();
            Thread.Sleep(10000);
            Assert.IsTrue(DifferentPlan.OkTransfer);
        }

        [TestMethod]
        public void Activities()
        {
            DifferentPlan.Instance();
            DifferentPlan.URL();
            DifferentPlan.Activities();
        }

        [TestMethod]
        public void Airbnb()
        {
            DifferentPlan.Instance();
            DifferentPlan.URL();
            DifferentPlan.Airbnb();
        }

        [TestMethod]
        public void ChooseGicci()
        {
            PrepereForTravel.Instance();
            PrepereForTravel.URL2();
            PrepereForTravel.ChooseThings();
            Assert.IsTrue(PrepereForTravel.OkGucci);
        }

        [TestMethod]
        public void Asktemplate()
        {
            Ask.Instance();
            Ask.URL();
            Ask.AskTemplate();
            Thread.Sleep(30000);
            Assert.IsTrue(Ask.OkAsk);
        }

        [TestMethod]
        public void AskYour()
        {
            Ask.Instance();
            Ask.URL();
            Ask.AskYou();
            Thread.Sleep(10000);
            Assert.AreEqual("Unfortunately we are not sure what you would like to know. Could you rephrase your question?", Ask.ErrorAsk);
        }

        [TestMethod]
        public void Car()
        {
            ChooseTour.Instance();
            ChooseTour.URL2();
            ChooseTour.ChooseCar("Amsterdam");
            Thread.Sleep(20000);
            Assert.AreEqual("No results matching your criteria", ChooseTour.ErrorCarr);
        }

        [TestCleanup]
        public void Cleanup()
        {
           driver = null;
            foreach (var process in Process.GetProcessesByName("geckodriver"))
            {
                process.Kill();
            }
           
        }

    }
}
