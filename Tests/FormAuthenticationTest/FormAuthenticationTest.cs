using FirstAutoTest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.FormAuthenticationTest
{
    public class FormAuthenticationTest : BaseTest
    {


        [Test]
        public void PossitiveLogInTest()
        {
            Console.WriteLine("Starting PossitiveLogIn Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            //Click on form 
            Console.WriteLine("Click on form : ");
            FormAuthenticationPage formAuthentication = welcomPage.ClickFormAuthentication();
            Console.WriteLine("--------------OK!------------");



            // Enter username and password 
            Console.WriteLine("Enter username and password  : ");
            SecureAreaPage secureArea =   formAuthentication.LogIn("tomsmith", "SuperSecretPassword!");
            Console.WriteLine("--------------OK!------------");



            //verification
            // can rewrite to get url
            Console.WriteLine("Take currently url and secure url :");
            string currentUrl = _driver.Url;
            Assert.AreEqual(secureArea.GetUrlSecure(), currentUrl);
            Console.WriteLine("--------------OK!------------");


            // is button visible
            Console.WriteLine("Check is the button visible :");
            Assert.True(secureArea.IsLogOutButtonVisible(), "LogOut button is not visible");
            Console.WriteLine("--------------OK!------------");

            // is button visible
            Assert.True(secureArea.IsLogOutButtonVisible(), "LogOut button is not visible");


            //Successful log in message
            string expectedSuccessMessage = "You logged into a secure area!";
            string actualSuccessMassege = secureArea.GetSuccessMessageText(expectedSuccessMessage);
            Assert.True(actualSuccessMassege.Contains(expectedSuccessMessage),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + expectedSuccessMessage + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

        }


        [Test]
        public void NegativeUserNameLogInTest()
        {

            Console.WriteLine("Starting NegativeUserNameLogIn Test");
            Console.WriteLine("Open page");
            //Open page
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");



            //Click on form 
            Console.WriteLine("Click on form");
            FormAuthenticationPage formAuthentication = welcomPage.ClickFormAuthentication();
            Console.WriteLine("--------------OK!------------");

            // Enter username and password 
            Console.WriteLine("Enter username and password ");
            SecureAreaPage secureArea = formAuthentication.LogIn("tomsmit", "SuperSecretPassword!");
            Console.WriteLine("--------------OK!------------");
            

            //verification
            // can rewrite to get url
            Console.WriteLine("Take currently url and secure url");
            string currentUrl = _driver.Url;
            Assert.AreEqual(secureArea.GetUrlLogin(), currentUrl);
            Console.WriteLine("--------------OK!------------");


           

            //Successful log in message
            string expectedSuccessMessage = "Your username is invalid!";
            string actualSuccessMassege = secureArea.GetNegativeMessageText(expectedSuccessMessage);
            Assert.True(actualSuccessMassege.Contains(expectedSuccessMessage),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + expectedSuccessMessage + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }

        [Test]
        public void NegativePasswordLogInTest()
        {
            Console.WriteLine("Starting NegativePasswordLogIn Test");

            //Open page
            Console.WriteLine("Open page");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");


            //Click on form 
            Console.WriteLine("Click on form");
            FormAuthenticationPage formAuthentication = welcomPage.ClickFormAuthentication();
            Console.WriteLine("--------------OK!------------");

            Thread.Sleep(1000);
            // Enter username and password 
            Console.WriteLine("Enter username and password ");
            SecureAreaPage secureArea = formAuthentication.LogIn("tomsmith", "SuperSecretPassword");
            Console.WriteLine("--------------OK!------------");
            Thread.Sleep(1000);
          

            //verification
            // can rewrite to get url
            Console.WriteLine("Take currently url and secure url");
            string currentUrl = _driver.Url;
            Assert.AreEqual(secureArea.GetUrlLogin(), currentUrl);
            Console.WriteLine("--------------OK!------------");

           


            //Successful log in message
            string expectedSuccessMessage = "Your password is invalid!";
            string actualSuccessMassege = secureArea.GetNegativeMessageText(expectedSuccessMessage);
            Assert.True(actualSuccessMassege.Contains(expectedSuccessMessage),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + expectedSuccessMessage + "\nactualSuccessMessage: " + actualSuccessMassege);
            Console.WriteLine("--------------OK!------------");
        }



    }
}
