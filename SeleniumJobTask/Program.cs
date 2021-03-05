using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumJobTask.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumJobTask
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to the login page
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");

        }
        [Test]
        public void ExecuteTest()
        {
            //Initializing LoginPageObject
            LoginPageObject loginPageObject = new LoginPageObject(driver);
            //Initializing PageObject
            PageObject pageObject = loginPageObject.Login("Admin", "Admin");
            pageObject.FillUserForm("FB", "Filip", "Boric", "Mr.");
        }
        [TearDown]
        public void Cleanup()
        {
            //Closing chrome
            driver.Close();
        }
    }
}
