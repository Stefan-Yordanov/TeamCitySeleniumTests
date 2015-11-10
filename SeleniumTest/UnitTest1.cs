using System;
using System.Drawing.Imaging;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void SeleniumTets()
        {
            using (var driver = new FirefoxDriver(new FirefoxBinary("D:\\Program Files\\Mozilla Firefox\\firefox.exe"), new FirefoxProfile()))
            //using (var driver = new EdgeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:5956");
                driver.Navigate().GoToUrl("http://localhost:5956");
                driver.GetScreenshot().SaveAsFile("data.png",ImageFormat.Png);
                System.IO.File.WriteAllText("Text.txt",driver.FindElement(By.TagName("innerHTML")).Text);
                driver.FindElements(By.TagName("a")).First(a => a.Text.Equals("About", StringComparison.InvariantCultureIgnoreCase)).Click();
                Assert.AreEqual(driver.Url, "http://localhost:5956/Home/About");
            }
        }

        [Test]
        public void SimpleTest()
        {
            Assert.AreEqual(1,1);
        }
    }
}
