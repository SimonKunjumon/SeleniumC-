using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            String title = driver.Title;
            IWebElement username = driver.FindElement(By.XPath("//input[@type='text' and @name='user-name']"));
            username.SendKeys ("standard_user");
            IWebElement password = driver.FindElement(By.XPath("//input[@type='password']"));
            password.SendKeys("secret_sauce");
            IWebElement login = driver.FindElement(By.XPath("//input[@type='submit']"));
            login.Click();
            Assert.AreEqual("Swag Labs", title);

            
        }
    }
}
