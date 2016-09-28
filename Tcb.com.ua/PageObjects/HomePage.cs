using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tcb.com.ua.PageObjects
{
    class HomePage : Page
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        #region Methods

        public void Open()
        {
            Driver.Navigate().GoToUrl("https://tcb.com.ua/");
        }

        public void Login()
        {
            Link_Login.Click();
        }

        #endregion

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[@href='/login/']")]
        private IWebElement Link_Login;

        #endregion

    }
}
