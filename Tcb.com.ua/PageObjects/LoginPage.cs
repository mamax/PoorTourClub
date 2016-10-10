using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tcb.com.ua.PageObjects
{
    public class LoginPage : Page
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        #region WebElements

        [FindsBy(How=How.Id, Using = "bfb")]
        private IWebElement Buttton_Facebook;

        #endregion

        public FaceBookPage LoginInFB()
        {
            Buttton_Facebook.Click();
            return new FaceBookPage(Driver);
        }

        public override void Open()
        {
            Driver.Navigate().GoToUrl("https://tcb.com.ua/login/");
        }
    }
}
