using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }

        [Test]
        public void ExecuteAutomationTest()
        {
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("admin");
            Driver.FindElement(By.Name("Password")).SendKeys("admin");
            Driver.FindElement(By.Name("Login")).Submit();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }


    }
}
