using OpenQA.Selenium;
using SeleniumJobTask.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumJobTask.PageObjects
{
    class PageObject
    {
        private readonly IWebDriver _driver;
        public PageObject(IWebDriver driver) => _driver = driver;

        public IWebElement dropDownListId => _driver.FindElement(By.Id("TitleId"));
        public IWebElement txtForInitialField => _driver.FindElement(By.Name("Initial"));
        public IWebElement txtForFirstNameField => _driver.FindElement(By.Name("FirstName"));
        public IWebElement txtForMiddleNameField => _driver.FindElement(By.Name("MiddleName"));
        public IWebElement btnSave => _driver.FindElement(By.Name("Save"));

        public void FillUserForm(string initial, string firstName, string middleName, string dropDownId)
        {
            dropDownListId.SelectDropdown(dropDownId);
            txtForInitialField.EnterText(initial);
            txtForFirstNameField.EnterText(firstName);
            txtForMiddleNameField.EnterText(middleName);
        }
    }
}
