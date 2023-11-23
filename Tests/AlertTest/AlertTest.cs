using FirstAutoTest;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.AlertTest
{
    public class AlertTest : BaseTest
    {
        [Test]
        public void JSAlertTest()
        {
            Console.WriteLine("Starting JSAlertTest ");

            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            //Click on form 
            Console.WriteLine("Click on form : ");
            JavaScriptAlertsPage javaScriptAlerts = welcomPage.ClickJavaScriptAlerts();
            Console.WriteLine("--------------OK!------------");


            //Click on button 
            Console.WriteLine("Click JS Alert Button : ");
            javaScriptAlerts.OpenJSAlert();
            Console.WriteLine("--------------OK!------------");


            //Get alert text
            Console.WriteLine("Get alert text : ");
            string AlertMessege = javaScriptAlerts.GetAlertText();
            Console.WriteLine("--------------OK!------------");


            //Click on button 
            Console.WriteLine("Click JS Alert Button : ");
            javaScriptAlerts.AcceptAlert();
            Console.WriteLine("--------------OK!------------");


            //Get resul text
            Console.WriteLine("Get resul text : ");
            string result = javaScriptAlerts.GetResultText();
            Console.WriteLine("--------------OK!------------");


            //Verifications 
            //1 - Alert text is expected
            Assert.True(AlertMessege.Equals("I am a JS Alert"),
               "Alert message is not expected. \nShould be 'I am a JS Alert', but it is '" + AlertMessege + "'");
            Thread.Sleep(2000);
            //2 - Result text is expected
            Assert.True(result.Equals("You successfully clicked an alert"),
               "result is not expected. \nShould be 'You successfuly clicked an alert', but it is '" + result + "'");
        }
        [Test]
        public void JSDismissTest()
        {
            Console.WriteLine("Starting jsDismissTest");

            // open main page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomePage = new WelcomPageObject(_driver);
            welcomePage.OpenPage();
            Console.WriteLine("--------------OK!------------");


            // Click on JavaScript Alerts link
            Console.WriteLine("Click on form : ");
            JavaScriptAlertsPage alertsPage = welcomePage.ClickJavaScriptAlerts();
            Console.WriteLine("--------------OK!------------");

            // Click JS Confirm button
            Console.WriteLine("Click JS Confirm Button : ");
            alertsPage.OpenJSConfirm();
            Thread.Sleep(1000);
            // Get alert text
            String alertMessage = alertsPage.GetAlertText();
            Console.WriteLine("--------------OK!------------");

            // Click Cancel button
            Console.WriteLine("Click JS Alert Button : ");
            alertsPage.DismissAlert();
            Console.WriteLine("--------------OK!------------");

            // Get Results text
            Console.WriteLine("Get resul text : ");
            string result = alertsPage.GetResultText();
            Thread.Sleep(1000);
            // Verifications
            Console.WriteLine("Verifications : ");
            // 1 - Alert text is expected
            Assert.True(alertMessage.Equals("I am a JS Confirm"),
                    "Alert message is not expected. \nShould be 'I am a JS Confirm', but it is '" + alertMessage + "'");
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Get resul text : ");
            // 2 - Result text is expected
            Assert.True(result.Equals("You clicked: Cancel"),
                    "result is not expected. \nShould be 'You clicked: Cancel', but it is '" + result + "'");
            Console.WriteLine("--------------OK!------------");

        }
        [Test]
        public void jsPromptTest()
        {
            Console.WriteLine("Starting jsDismissTest");

            // open main page
            Console.WriteLine("open main page");
            WelcomPageObject welcomePage = new WelcomPageObject(_driver);
            welcomePage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            // Click on JavaScript Alerts link
            Console.WriteLine("Click on JavaScript Alerts link");
            JavaScriptAlertsPage alertsPage = welcomePage.ClickJavaScriptAlerts();
            Console.WriteLine("--------------OK!------------");



            // Click JS Prompt button
            Console.WriteLine(" Click JS Prompt button");
            alertsPage.OpenJSPrompt();
            Thread.Sleep(1000);
            // Get alert text
            string alertMessage = alertsPage.GetAlertText();
            Console.WriteLine("--------------OK!------------");



            // Type text into alert
            Console.WriteLine("Type text into alert");
            alertsPage.TypeTextIntoAlert("Hello Alert, it's Dmitry here");
            Thread.Sleep(1000);
            // Get Results text
            String result = alertsPage.GetResultText();
            Thread.Sleep(1000);
            Console.WriteLine("--------------OK!------------");



            // Verifications
            // 1 - Alert text is expected
            Console.WriteLine("Alert text is expected");
            Assert.True(alertMessage.Equals("I am a JS prompt"),
                    "Alert message is not expected. \nShould be 'I am a JS prompt', but it is '" + alertMessage + "'");
            Console.WriteLine("--------------OK!------------");


            // 2 - Result text is expected
            Console.WriteLine(" Result text is expected");
            Assert.True(result.Equals("You entered: Hello Alert, it's Dmitry here"),
                    "result is not expected. \nShould be 'You entered: Hello Alert, its Dmitry here', but it is '" + result
                            + "'");
            Console.WriteLine("--------------OK!------------");

        }
    }
}
