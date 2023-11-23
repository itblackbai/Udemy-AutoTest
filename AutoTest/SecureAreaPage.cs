using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class SecureAreaPage : BaseObjectPage
    {
        public SecureAreaPage(IWebDriver driver) : base(driver)
        {
        }

        private string pageUrl = "https://the-internet.herokuapp.com/secure";
        private string urlLogin = "https://the-internet.herokuapp.com/login";

        private By logOutButton = By.XPath("//a[@class='button secondary radius']");
        private By message = By.Id("flash-messages");
        private By errorMessage = By.Id("flash");

        /** Get URL variable from PageObject */
        public string GetUrlSecure()
        {
            return pageUrl;
        }
        public string GetUrlLogin()
        {
            return urlLogin;
        }
        /** Verification if logOutButton is visible on the page */
        public bool IsLogOutButtonVisible()
        {
            return Find(logOutButton).Displayed;
        }
        /** Return text from success message */
        public string GetSuccessMessageText(string mess)
        {
            return Find(message).Text;
        }
        public string GetNegativeMessageText(string mess)
        {
            return Find(errorMessage).Text;
        }



    }
}
