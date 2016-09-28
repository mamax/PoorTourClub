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
        }

        private static IWebDriver StartWebDriver()
        {
            if (Driver != null)
                return Driver;
            else
            {
                Driver = StartChrome();
            }
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
