using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tcb.com.ua.PageObjects
{
    public class TripsPage : Page
    {
        public TripsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public static string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string newDirectory = currentDirectory.Replace("bin\\Debug", "ScreenShots\\");

        public FirstStepPage FindPerson(string name)
        {
            var isFound = false;
            for (var i = 0; i < _moreDetailButtons.Count; i++)
                if (!isFound)
                {
                    _moreDetailButtons.ElementAt(i).Click();

                    if (ElementIsVisible(Button_OrderPlace()))
                    {
                        Driver.FindElement(Button_OrderPlace()).Click();
                        Thread.Sleep(200);
                        WaitForElementEnabledAndDisplayed(Chkb_Rules());
                        Driver.FindElement(Chkb_Rules()).Click();
                        Chkb_Dogovir.Click();
                        Chkb_Data.Click();
                        Button_NextPage.Click();
                        Thread.Sleep(200);

                        foreach (var cell in CellList)
                            if (cell.GetAttribute("title").Contains(name))
                            {
                                SaveScreenshot(newDirectory + name + ".jpeg");
                                Console.WriteLine(element.Text);
                                isFound = true;
                                break;
                            }
                        moveBack();
                    }
                    else
                    {
                        Driver.Navigate().Back();
                    }
                }
            return new FirstStepPage(Driver);
        }

        public override void Open()
        {
            Driver.Navigate().GoToUrl("https://tcb.com.ua/trips/");
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[text()='Детальніше']")]
        private IList<IWebElement> _moreDetailButtons;

        [FindsBy(How = How.Id, Using = "phone")]
        private IWebElement Button_Phone;

        [FindsBy(How = How.Id, Using = "fathername")]
        private IWebElement Input_Family;

        [FindsBy(How = How.Id, Using = "bday1")]
        private IWebElement Input_DateOfBirth;

        private By Chkb_Rules()
        {
            return By.XPath("//input[@name='igeerule']");
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='igeerule2']")]
        private IWebElement Chkb_Dogovir;

        [FindsBy(How = How.XPath, Using = "//input[@name='iamanonim']")]
        private IWebElement Chkb_Data;

        [FindsBy(How = How.XPath, Using = "//div[text()='Наступний крок']")]
        private IWebElement Button_NextPage;

        [FindsBy(How = How.XPath, Using = "//div[@class='bused']/table/tbody/tr/td")]
        private IList<IWebElement> CellList;

        [FindsBy(How = How.XPath, Using = "//h1/span")]
        private IWebElement element;

        private By Button_OrderPlace()
        {
            return By.XPath("//div[@class='allbut']");
        }

        #endregion
    }
}