using NUnit.Framework;
using OpenQA.Selenium;

namespace Tcb.com.ua
{
    public class BaseTest
    {

        protected static IWebDriver Driver = PropertiesCollection.Driver;

        [SetUp]
        public void TestInitialize()
        {
            Browser.Start();
        }

        [TearDown]
        public void TestCleanup()
        {
            Browser.Quit();
        }
    }
}
