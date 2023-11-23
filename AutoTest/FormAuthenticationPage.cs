
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class FormAuthenticationPage : BaseObjectPage
    {
        public FormAuthenticationPage(IWebDriver driver) : base(driver)
        {
        }


        private By userNameLocator = By.Id("username");
        private By passwordLocator = By.Name("password");
        private By logInButtonLocator = By.TagName("button");

        private By errorMessageLocator = By.Id("flash");




        public SecureAreaPage LogIn(string username, string password)
        {
            Type(username, userNameLocator);
            Type(password, passwordLocator);
            Click(logInButtonLocator);
            return new SecureAreaPage(_driver);
        }


        public void NegativeLogIn(string username, string password)
        {
            Type(username, userNameLocator);
            Type(password, passwordLocator);
            Click(logInButtonLocator);
        }

        public void WaitForErrorMessage()
        {
            WaitForVisibilityOf(errorMessageLocator, 5);
        }

        public String GetErrorMessageText()
        {
            return Find(errorMessageLocator).Text;
        }
















        /*
        // Test Data
        public static string urlLogin { get; set; } = "https://the-internet.herokuapp.com/login";
        public static string urlPositive { get; set; } = "https://the-internet.herokuapp.com/secure";
        public static string possitiveEmail { get; set; } = "tomsmith";
        public static string possitivePassword { get; set; } = "SuperSecretPassword!";
        public static string negativeEmail { get; set; } = "tomsmit";
        public static string negativePassword = "SuperSecretPassword";
        public static string loginMess = "You logged into a secure area!";
        public static string errPasswordMess = "Your password is invalid!";
        public static string errUserMess = "Your username is invalid!";



        // Find element 
        IWebElement txtEmail => _driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement txtPassword => _driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement btnLogin => _driver.FindElement(By.XPath("//i[@class='fa fa-2x fa-sign-in']"));

        IWebElement errMessage => _driver.FindElement(By.XPath("//div[@id='flash']"));
        IWebElement posstiveMessege => _driver.FindElement(By.XPath("//div[@id='flash']"));




        public void SetEmail(string text) => txtEmail.SendKeys(text);
        public void SetPassword(string text) => txtPassword.SendKeys(text);
        public void ClickLogin() => btnLogin.Click();
        public string GetErrorMessege() => errMessage.Text;
        public string GetPossitiveMessege() => posstiveMessege.Text;
        */
    }
}
