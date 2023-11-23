using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.MultipleWindows
{
    public class MultipleWindowsTest : BaseTest
    {
        [Test]
        public void NewWindowsTest()
        {
            Console.WriteLine("Starting New Windows Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            //Click on form 
            Console.WriteLine("Click on form : ");
            MultipleWindowsPage windowsPage = welcomPage.ClickMultipleWindows();
            Console.WriteLine("--------------OK!------------");


            //Click to click here link to opne new page 
            Console.WriteLine("Open new page");
            windowsPage.OpenNewWindows();
            Console.WriteLine("--------------OK!------------");

            //Find and switch to new window page
            Console.WriteLine("Find and switch to new window page");
            NewWindoPage newWindoPage = windowsPage.SwitchToNewWindowPage();
            Console.WriteLine("--------------OK!------------");


            //Take current source url
            Console.WriteLine("Take current source url");
            //string currentUrl = _driver.Url;
            string pageSource = newWindoPage.GetCurrentlyPageSource();
            Console.WriteLine("--------------OK!------------");


            // Verification that new page contains expected text in source
            Console.WriteLine("Check that page contains expected in source:");
            Assert.True(pageSource.Contains("New Window"), "New page source doesn't containse New Windos");
        }
    }
}
