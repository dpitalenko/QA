using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace Rwby.Tests
{
    [TestClass]
    public class RwbyTest
    {
        private IWebDriver driver;

        [TestInitialize]
        [Obsolete]
        public void BrowserSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            driver.Navigate().GoToUrl("https://rw.by/");
        }

        //[TestMethod]
        //[Obsolete]
        //public void Search()
        //{
        //    driver.FindElement(By.XPath("//div[@class='wrap']/a[@href='https://pass.rw.by/ru/']")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //       .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/"));

        //    driver.FindElement(By.XPath("//*[@id='db']/div[1]/div[1]/div/header/div/div[2]/div[5]/div[2]/div")).Click();
        //    driver.FindElement(By.XPath("//input[@id='headSearch']")).SendKeys("минск");                              
        //    driver.FindElement(By.XPath("//input[@class='btn-search']")).Click();


        //    Assert.IsNotNull(driver.FindElement(By.XPath("//*[@class='search-result__inner']")));
        //}

        //[TestMethod]
        //[Obsolete]
        //public void AddTicketToCard()
        //{
        //    driver.FindElement(By.XPath("//div[@class='wrap']/a[@href='https://pass.rw.by/ru/']")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //       .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/"));

        //    driver.FindElement(By.XPath("//li[@class='item_1 cabinet']/a")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='modal-content']/div[@class='auth-modal__header']")));

        //    driver.FindElement(By.Name("login")).SendKeys("dpitalenko");
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.TextToBePresentInElementValue(By.Name("login"), "dpitalenko"));

        //    driver.FindElement(By.Name("password")).SendKeys("123456789rwby");
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.TextToBePresentInElementValue(By.Name("password"), "123456789rwby"));

        //    driver.FindElement(By.XPath("//*[@value='Войти']")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/?path=ru%2F"));


        //    driver.FindElement(By.XPath("//input[@id='one-way-raspFormFromTitle']")).SendKeys("Минск");
        //    driver.FindElement(By.XPath("//input[@id='one-way-raspFormToTitle']")).SendKeys("Брест");
        //    //time
        //    driver.FindElement(By.XPath("//*[@id='filter-tab_2-1']/form/div/div[2]/div/div[2]/a[2]")).Click();  
        //    //button find
        //    driver.FindElement(By.XPath("//*[@id='filter-tab_2-1']//div[@class='rasp-form__btn-wrap']/button")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sch-table js-schSort js-schedule']")));

        //    //choice
        //    driver.FindElement(By.XPath("//*[@id='sch-route']/div[3]/div[2]/div[1]/div[3]/div/div[2]/div/div[4]/div[2]/form/a")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/order/places/"));
        //    //coupe
        //    driver.FindElement(By.XPath("//*[@id='app-place-choice']/div[2]/div[2]/div[2]/a[2]")).Click();
        //    //train num
        //    driver.FindElement(By.XPath("//*[@id='carriage-collapse-list']/div[1]/div[1]")).Click();
        //    //auto
        //    driver.FindElement(By.XPath("//*[@id='app-place-choice']/div[2]/div[4]/div/form/div[1]/div/div/div/div[2]/div[2]/div/a")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/order/passengers/"));

        //    driver.FindElement(By.XPath("//*[@id='passengersInfo']//input[@name='last_name_1']")).SendKeys("Иванов");
        //    driver.FindElement(By.XPath("//*[@id='passengersInfo']//input[@name='first_name_1']")).SendKeys("Иван");
        //    //passport
        //    driver.FindElement(By.XPath("//*[@id='passengersInfo']//input[@name='document_number_1']")).SendKeys("МР1234567");
        //    driver.FindElement(By.XPath("//button[text()='Оформить заказ']")).Click();
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(30))
        //        .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/order/payment/?added_to_basket=1"));

        //    Assert.IsNotNull(driver.FindElement(By.XPath("//*[@id='PayForm']")));
        //}

        [TestMethod]
        [Obsolete]
        public void ChangeCurrency()
        {
            driver.FindElement(By.XPath("//div[@class='wrap']/a[@href='https://pass.rw.by/ru/']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
               .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/"));

            driver.FindElement(By.XPath("//li[@class='item_1 cabinet']/a")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='modal-content']/div[@class='auth-modal__header']")));

            driver.FindElement(By.Name("login")).SendKeys("dpitalenko");
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.TextToBePresentInElementValue(By.Name("login"), "dpitalenko"));

            driver.FindElement(By.Name("password")).SendKeys("123456789rwby");
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.TextToBePresentInElementValue(By.Name("password"), "123456789rwby"));

            driver.FindElement(By.XPath("//*[@value='Войти']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/?path=ru%2F"));


            driver.FindElement(By.XPath("//input[@id='one-way-raspFormFromTitle']")).SendKeys("Минск");
            driver.FindElement(By.XPath("//input[@id='one-way-raspFormToTitle']")).SendKeys("Брест");
            //time
            driver.FindElement(By.XPath("//*[@id='filter-tab_2-1']/form/div/div[2]/div/div[2]/a[2]")).Click();
            //button find
            driver.FindElement(By.XPath("//*[@id='filter-tab_2-1']//div[@class='rasp-form__btn-wrap']/button")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sch-table js-schSort js-schedule']")));

            //choice
            driver.FindElement(By.XPath("//*[@id='sch-route']/div[3]/div[2]/div[1]/div[3]/div/div[2]/div/div[4]/div[2]/form/a")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/order/places/"));
            //coupe
            driver.FindElement(By.XPath("//*[@id='app-place-choice']/div[2]/div[2]/div[2]/a[2]")).Click();
            //train num
            driver.FindElement(By.XPath("//*[@id='carriage-collapse-list']/div[1]/div[1]")).Click();
            //auto
            driver.FindElement(By.XPath("//*[@id='app-place-choice']/div[2]/div[4]/div/form/div[1]/div/div/div/div[2]/div[2]/div/a")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/order/passengers/"));

            driver.FindElement(By.XPath("//*[@id='passengersInfo']//input[@name='last_name_1']")).SendKeys("Иванов");
            driver.FindElement(By.XPath("//*[@id='passengersInfo']//input[@name='first_name_1']")).SendKeys("Иван");
            //passport
            driver.FindElement(By.XPath("//*[@id='passengersInfo']//input[@name='document_number_1']")).SendKeys("МР1234567");
            driver.FindElement(By.XPath("//button[text()='Оформить заказ']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50))
                .Until(ExpectedConditions.UrlToBe("https://pass.rw.by/ru/order/payment/?added_to_basket=1"));

            driver.FindElement(By.XPath("//*[@id='Currency']/a")).Click();
            IWebElement NewCurrency = driver.FindElement(By.XPath("//*[@id='Currency']/div/ul/li[4]/a"));
            NewCurrency.Click();

            IWebElement BasketCurrency = driver.FindElement(By.XPath("//*[@id='OrdersBasket']/div[2]/div[2]/div/table/tbody/tr/td[8]/div[2]/span"));
            
            Assert.IsFalse((NewCurrency.Text).Equals(BasketCurrency));
        }

        [TestCleanup]
        public void BrowserTearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
