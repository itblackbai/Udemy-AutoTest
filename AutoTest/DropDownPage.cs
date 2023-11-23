using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class DropDownPage : BaseObjectPage
    {
        public DropDownPage(IWebDriver driver) : base(driver)
        {
        }


        private By dropdown = By.Id("dropdown");


        public void SelectOption(int i)
        {

            Console.WriteLine($"Selecting option {i} from dropdown");
            IWebElement dropdownElement = Find(dropdown);
            SelectElement selectDropdown = new SelectElement(dropdownElement);

            // There are three ways to use Select class
            // #1
            //selectDropdown.SelectByIndex(i);

            // #2
            selectDropdown.SelectByValue(i.ToString());

            // #3
            //selectDropdown.SelectByText($"Option {i}");
        }

        /** This method returns selected option in dropdown as a string */
        public string GetSelectedOption()
        {
            IWebElement dropdownElement = Find(dropdown);
            SelectElement selectDropdown = new SelectElement(dropdownElement);
            string selectedOption = selectDropdown.SelectedOption.Text;
            Console.WriteLine($"{selectedOption} is selected in dropdown");
            return selectedOption;
        }

    }
}
