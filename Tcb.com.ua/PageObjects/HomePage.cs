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

        public override void Open()
        {
            Driver.Navigate().GoToUrl("https://tcb.com.ua/");
        }

        public LoginPage Login()
        {
            Link_Login.Click();
            return new LoginPage(Driver);
        }

        #endregion

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[@href='/login/']")]
        private IWebElement Link_Login;

        #endregion

    }

}
