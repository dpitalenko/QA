using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Rwby.Tests_PageObject_.PageObjects
{
    class HomePage
    {

        private IWebDriver driver;

        [Obsolete]
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='wrap']/a[@href='https://pass.rw.by/ru/']")]
        private IWebElement PassengerPage;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.rw.by/");
        }

        [Obsolete]
        public PassengerPage GoToPassengerPage()
        {
            PassengerPage.Click();
            return new PassengerPage(driver);
        }
    }
}