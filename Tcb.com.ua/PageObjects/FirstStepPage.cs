using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tcb.com.ua.PageObjects
{
    public class FirstStepPage :Page
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='delbutton']")]
        private IWebElement Button_Delete;

        [FindsBy(How=How.XPath, Using = "//div[text()='Додати ще учасника']")]
        private IWebElement Button_AddUser;

        public FirstStepPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        //public SecondStepPage AddUser(string ladminPhone, string ladminName, string ladminSurname, string ladminFather, string ladminDateOfBirth)
        //{
        //    Button_Delete.Click();
        //    Button_AddUser.Click();
        //    AddPerson(ladminPhone, ladminName, ladminSurname, ladminFather, ladminDateOfBirth);
        //    Button_NextStep.Click();
        //    return new SecondStepPage(Driver);
        //}

        //private void AddPerson(string ladminPhone, string ladminName, string ladminSurname, string fatherName, string ladminDateOfBirth)
        //{
        //    ClearAndType(phoneFld, ladminPhone);
        //    ClearAndType(surnameFld, ladminName);
        //    ClearAndType(nameFld, ladminSurname);
        //    ClearAndType(fatherFld, fatherName);
        //    ClearAndType(dateOfBirthFld, ladminDateOfBirth);
        //}

        #region WebElements

        [FindsBy(How=How.Id, Using = "phone")]
        private IWebElement phoneFld;

        [FindsBy(How = How.Id, Using = "soname")]
        private IWebElement surnameFld;

        [FindsBy(How = How.Id, Using = "name1")]
        private IWebElement nameFld;

        [FindsBy(How = How.Id, Using = "fathername")]
        private IWebElement fatherFld;

        [FindsBy(How = How.Id, Using = "bday1")]
        private IWebElement dateOfBirthFld;

        [FindsBy(How = How.XPath, Using = "//div[text()='Наступний крок']")]
        private IWebElement Button_NextStep;

        #endregion

        public override void Open()
        {
        }
    }
}
