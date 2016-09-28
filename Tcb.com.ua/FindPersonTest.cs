using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Tcb.com.ua.PageObjects;

namespace Tcb.com.ua
{
    public class FindPersonTest : BaseTest
    {
        [Test]
        public void TestFindPerson()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Open();
            homePage.Login();

        }
    }

}
