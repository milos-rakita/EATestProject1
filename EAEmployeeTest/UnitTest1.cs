using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        public string url = "http://localhost/EmployeeApp";

        private IWebDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(url);


        }

        public void Login()
        {
            _driver.FindElement(By.LinkText("Log in")).Click();

            //username
            _driver.FindElement(By.Id("UserName")).SendKeys("admin");
            _driver.FindElement(By.Id("Password")).SendKeys("password");

            //click button
            _driver.FindElement(By.CssSelector("input.btn")).Submit();

        }
    }
}
