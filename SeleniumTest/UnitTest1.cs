using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
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

        [Test]
        public void SimpleTest()
        {
            Assert.AreEqual(1,2);
        }
    }
}
