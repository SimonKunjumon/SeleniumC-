using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BasePage
{

   
    public class BaseClass
    {

       

       public IWebDriver driver;
        [SetUp]
        public void initialize()
        {
            driver = new ChromeDriver();
            driver = new FirefoxDriver();
            driver =new SafariDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
           

        }
    }
}
