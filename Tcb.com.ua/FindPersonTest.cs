using System;
using NUnit.Framework;
using Tcb.com.ua.PageObjects;

namespace Tcb.com.ua
{
    public class FindPersonTest : BaseTest
    {
        private UserData fbAccount = new UserData("maksim.mazurkevych@gmail.com", "gtnhjdbx2014");
        private const String name = "Дудник Оксана";

        [Test]
        public void TestFindPerson()
        {
            LoginToApp();
            TripsPage tripsPage = new TripsPage(Driver);
            tripsPage.Open();
            tripsPage.FindPerson(name);
        }

        private void LoginToApp()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Open();
            LoginPage loginPage = homePage.Login();
            FaceBookPage faceBookPage = loginPage.LoginInFB();
            faceBookPage.EnterFBCreds(fbAccount.email, fbAccount.pass);
            faceBookPage.ClickTripsButton();
        }
    }

}
