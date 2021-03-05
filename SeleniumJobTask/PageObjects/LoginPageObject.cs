using OpenQA.Selenium;
using SeleniumJobTask.Methods;
using SeleniumJobTask.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumJobTask
{
    class LoginPageObject
    {
        private readonly IWebDriver _driver;
        public LoginPageObject(IWebDriver driver) => _driver = driver;

        public IWebElement txtForUserNameField => _driver.FindElement(By.Name("UserName"));
        public IWebElement txtForPasswordField => _driver.FindElement(By.Name("Password"));

        public IWebElement btnLogin => _driver.FindElement(By.Name("Login"));

        public PageObject Login(string userName, string password)
        {
            txtForUserNameField.EnterText(userName);
            txtForPasswordField.EnterText(password);
            btnLogin.Submit();
            return new PageObject(_driver);
        }
    }
}
