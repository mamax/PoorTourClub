using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tcb.com.ua.PageObjects
{
    public class FaceBookPage : Page
    {
        public FaceBookPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        internal void EnterFBCreds(String email, String pass)
        {
            ClearAndType(mailFld, email);
            ClearAndType(passFld, pass);
            Button_Login.Click();
            islogged = true;
        }

        #region WebElements

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement mailFld;

        [FindsBy(How = How.Id, Using = "pass")]
        private IWebElement passFld;

        [FindsBy(How = How.Id, Using = "loginbutton")]
        private IWebElement Button_Login;

        protected bool islogged;

        #endregion

        public void ClickTripsButton()
        {
            Driver.Navigate().GoToUrl("https://tcb.com.ua/trips/");
        }

        public override void Open()
        {
        }
    }
}
