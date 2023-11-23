using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class JavaScriptAlertsPage : BaseObjectPage
    {
        public JavaScriptAlertsPage(IWebDriver driver) : base(driver)
        {
        }

        private By clickForJSAlertButtonLocator = By.XPath("//button[text()='Click for JS Alert']");
        private By clickForJSConfirmButtonLocator = By.XPath("//button[text()='Click for JS Confirm']");
        private By clickForJSPromptButtonLocator = By.XPath("//button[text()='Click for JS Prompt']");
        private By resultTextLocator = By.Id("result");

        /** Clicking on 'Click for JS Alert' button to open alert */
        public void OpenJSAlert()
        {
            Console.WriteLine("Clicking on 'Click for JS Alert' button to open alert");
            Click(clickForJSAlertButtonLocator);

        }

        /** Clicking on 'Click for JS Confirm' button to open alert */
        public void OpenJSConfirm()
        {
            Console.WriteLine("Clicking on 'Click for JS Confirm' button to open alert");
            Click(clickForJSConfirmButtonLocator);
        }

        /** Clicking on 'Click for JS Prompt' button to open alert */
        public void OpenJSPrompt()
        {
            Console.WriteLine("Clicking on 'Click for JS Prompt' button to open alert");
            Click(clickForJSPromptButtonLocator);
        }

        /** Switch to alert and get it's message */
        public String GetAlertText()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Console.WriteLine("Alert says: " + alertText);
            return alertText;
        }

        /** Switch to alert and press OK */
        public void AcceptAlert()
        {
            Console.WriteLine("Switching to alert and pressing OK");
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }

        /** Switch to alert and press Cancel */
        public void DismissAlert()
        {
            Console.WriteLine("Switching to alert and pressing Cancel");
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        /** Type text into alert and press OK */
        public void TypeTextIntoAlert(String text)
        {
            Console.WriteLine("Typing text into alert and pressing OK");
            IAlert alert = _driver.SwitchTo().Alert();
            alert.SendKeys(text);
            alert.Accept();
        }

        /** Get result text */
        public string GetResultText()
        {
            string result = Find(resultTextLocator).Text;
            Console.WriteLine("Result text: " + result);
            return result;
        }

    }
}
