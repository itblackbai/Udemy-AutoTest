using FirstAutoTest;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.KeyPressesTests
{
    public class KeyPressesTests : BaseTest
    {
        [Test]
        public void PressKeyTest()
        {
            Console.WriteLine("Starting PressKey Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");




            //Click on form 
            Console.WriteLine("Click on form : ");
            KeyPressPage keyPress = welcomPage.ClickKeyPress();
            Console.WriteLine("--------------OK!------------");

            // Push keybord key
            Console.WriteLine("Push keybord key");
            keyPress.PressKey(Keys.Enter);
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Get result from text");
            string result = keyPress.GetResultText();
            Console.WriteLine("--------------OK!------------");


            Console.WriteLine("Equals");
            Assert.True(result.Equals("You entered: ENTER"),
                "Result is not expecteed. Result is : " + result);
            Console.WriteLine("--------------OK!------------");




        }
        [Test]
        public void PressKeyWithActionsTest()
        {
            Console.WriteLine("Starting Press Key With Actions Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");
            //Click on form 
            Console.WriteLine("Click on form : ");
            KeyPressPage keyPress = welcomPage.ClickKeyPress();
            Console.WriteLine("--------------OK!------------");

            // Push keybord key
            Console.WriteLine("Push keybord key");
            keyPress.PressKeyWithActions(Keys.Space);
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Get result from text");
            string result = keyPress.GetResultText();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Equals");

            Assert.True(result.Equals("You entered: SPACE"),
                "Result is not expecteed. Result is : " + result);
            Console.WriteLine("--------------OK!------------");

        }
    }
}
