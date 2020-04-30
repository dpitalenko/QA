using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Rwby.Tests_PageObject_.PageObjects;
using System;

namespace Rwby.Tests_PageObject_
{
    [TestClass]
    public class RwbtTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void BrowserSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        [Obsolete]
        public void CorrectLogIn()
        {
            HomePage home = new HomePage(driver);
            home.GoToPage();
            PassengerPage passengerPage = home.GoToPassengerPage();
            ResultPage result = passengerPage.Authorization("dpitalenko", "123456789rwby");
            Assert.IsNotNull(result.IsLogIn());
        }

        [TestMethod]
        [Obsolete]
        public void ChangeLocationToENG()
        {
            HomePage home = new HomePage(driver);
            home.GoToPage();
            PassengerPage passengerPage = home.GoToPassengerPage();
            ResultPage result = passengerPage.ChangeLocalization();
            Assert.IsTrue(result.IsUrlCorrect());
        }

        [TestCleanup]
        public void BrowserTearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}