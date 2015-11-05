using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:5956");
                driver.FindElements(By.TagName("a"))
                    .First(a => a.Text.Equals("About", StringComparison.InvariantCultureIgnoreCase)).Click();
                Assert.AreEqual(driver.Url, "http://localhost:5956/Home/About");
            }
            
        }
    }
}
