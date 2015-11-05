using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void SeleniumTets()
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
            Assert.AreEqual(1,3);
        }
    }
}
