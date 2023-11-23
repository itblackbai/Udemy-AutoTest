using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class MultipleWindowsPage : BaseObjectPage
    {
        public MultipleWindowsPage(IWebDriver driver) : base(driver)
        {
        }

        private By clickHereLinlLocator = By.LinkText("Click Here");

        public void OpenNewWindows()
        {
            Console.WriteLine("Clicking on 'Click here' link");
            Click(clickHereLinlLocator);
        }

        public NewWindoPage SwitchToNewWindowPage()
        {
            Console.WriteLine("Looking for 'New window ' page ");
            SwitchToWindowWithTitle("New Window");
            return new NewWindoPage(_driver);
        }
    }
}
