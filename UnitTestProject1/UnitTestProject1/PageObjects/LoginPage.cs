using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject1.BasePage;
namespace UnitTestProject1.PageObjects
{
  public class LoginPage
    {
       public IWebDriver driver;
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By username = By.XPath("//input[@type='text' and @name='user-name']");
        By password = By.XPath("//input[@type='password']");
        By login = By.XPath("//input[@type='submit']");

        public String Login(String x, String y) 
        {   
            Thread.Sleep(1000);
            driver.FindElement(username).SendKeys(x);
            driver.FindElement(password).SendKeys(y);
            Thread.Sleep(1000);
            driver.FindElement(login).Click();
            String title = driver.Title;
            return title;
        }

    }
}
