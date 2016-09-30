using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tcb.com.ua
{
    public class Browser : BaseTest
    {
        public static void Start()
        {
            Driver = StartWebDriver();
            Driver.Manage().Window.Maximize();
        }

        private static IWebDriver StartWebDriver()
        {
            if (Driver != null)
                return Driver;
            else
            {
                Driver = StartChrome();
            }
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(40));
            return Driver;
        }

        private static IWebDriver StartChrome()
        {
            return new ChromeDriver();
        }

        public static void Quit()
        {
            if (Driver == null) return;
            else {
                Driver.Quit();
                Driver = null;
            }
            
        }
    }
}
