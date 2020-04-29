using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Rwby.Tests
{
    [TestClass]
    public class RwbyTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void BrowserUrl()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://rw.by/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

        }

        [TestMethod]
        [Obsolete]
        public void ChangeLocationToENG()
        {               
            driver.FindElement(By.XPath("//div[@class='wrap']/a[@href='https://pass.rw.by/ru/']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20))
               .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/"));

            driver.FindElement(By.XPath("//ul[@class='list list-reset clearfix']/li[@class='item']/a[@href='/en/?c=true']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
               .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/en/?c=true"));            

            Assert.IsTrue((driver.Url).Equals("https://pass.rw.by/en/?c=true"));
        }

        [TestMethod]
        [Obsolete]
        public void CorrectLogIn()
        {
            driver.FindElement(By.XPath("//div[@class='wrap']/a[@href='https://pass.rw.by/ru/']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20))
               .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/"));

            driver.FindElement(By.XPath("//li[@class='item_1 cabinet']/a")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='modal-content']/div[@class='auth-modal__header']")));

            driver.FindElement(By.Name("login")).SendKeys("dpitalenko");
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.TextToBePresentInElementValue(By.Name("login"), "dpitalenko"));

            driver.FindElement(By.Name("password")).SendKeys("123456789rwby");
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.TextToBePresentInElementValue(By.Name("password"), "123456789rwby"));

            driver.FindElement(By.XPath("//*[@value='Войти']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/?path=ru%2F"));

            Assert.IsNotNull(driver.FindElement(By.XPath("//li[@class='item_1 cabinet']/a/span[text()='Диана Питаленко']")), "Authorization Failed");
        }

        [TestCleanup]
        public void AfterBrowserTearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
