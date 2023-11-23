using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstAutoTest
{
    public class CheckboxPage : BaseObjectPage
    {
        public CheckboxPage(IWebDriver driver) : base(driver)
        {
        }

        private By checkbox = By.XPath("//input[@type='checkbox']");


        //Get list of all checkboxes and check if unchecked
        public void SelectAllCheckboxes()
        {
            Console.WriteLine("Checking all unchecked checkboxes");

            IList<IWebElement> checkboxes = _driver.FindElements(checkbox);

            foreach (IWebElement checkboxElement in checkboxes)
            {
                if (!checkboxElement.Selected)
                {
                    checkboxElement.Click();
                }
            }
        }

        //Verify all available checkboxes are checked.
        //If at least one unchecked, return false
        public bool AreAllCheckboxesChecked()
        {
            Console.WriteLine("Verifying that all checkboxes are checked");
            IList<IWebElement> checkboxes = _driver.FindElements(checkbox);

            foreach (IWebElement checkboxElement in checkboxes)
            {
                if (!checkboxElement.Selected)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
