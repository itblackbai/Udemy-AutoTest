
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{

    public class BaseTest
    {
        public IWebDriver? _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();

        }

       


    }
}