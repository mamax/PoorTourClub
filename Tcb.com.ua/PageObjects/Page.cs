using System;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tcb.com.ua.PageObjects
{
    public abstract class Page
    {

        public abstract void Open();

        protected static IWebDriver Driver;
        protected Page(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        protected void ClearAndType(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        protected void SaveScreenshot(string path)
        {
            GetScreenshot().SaveAsFile(path, ImageFormat.Jpeg);
        }

        public static Screenshot GetScreenshot()
        {
            return ((ITakesScreenshot)Driver).GetScreenshot();
        }

        protected void moveBack()
        {
            Driver.Navigate().Back();
            Driver.Navigate().Back();
            Driver.Navigate().Back();
        }

        protected Boolean ElementIsVisible(By element)
        {
            try
            {
                return Driver.FindElement(element).Displayed;
            }
            catch (Exception e)
            {
                if (e is NoSuchElementException || e is ElementNotVisibleException || e is WebDriverTimeoutException)
                {
                    return false;
                }
                throw;
            }
        }

        protected Boolean WaitForElementEnabledAndDisplayed(By element)
        {
            try
            {
                return Driver.FindElement(element).Enabled && Driver.FindElement(element).Displayed;
            }
            catch (Exception e)
            {
                if (e is NoSuchElementException || e is ElementNotVisibleException)
                {
                    return false;
                }
                throw;
            }
        }

    }
}
