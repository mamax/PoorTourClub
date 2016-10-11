using NUnit.Framework;
using OpenQA.Selenium;
using Tcb.com.ua.PageObjects;

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

        [TearDown]
        public void SendScreen()
        {
            SendEmail.sendMail("maksim.mazurkevych@gmail.com",
                "BIDnyajky",
                "Please find the reports attached.\n\n Regards\nQA Automation",
                TripsPage.newDirectory + FindPersonTest.name + ".jpeg");
        }
    }
}
