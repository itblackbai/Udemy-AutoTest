using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DropDownTest
{
    public class DropDownTest : BaseTest
    {
        [Test]
        public void OptionTwoTest()
        {
            Console.WriteLine("Starting OptionTwo Test");

            //Open page
            Console.WriteLine ("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");


            //Click on form 
            Console.WriteLine("Click on form : ");
            DropDownPage dropDown = welcomPage.ClickDropDown();
            Console.WriteLine("--------------OK!------------");

            Thread.Sleep(1000);
            //Select option 2
            Console.WriteLine("Select option 2 : ");
            dropDown.SelectOption(2);
            Console.WriteLine("--------------OK!------------");

            
            // Equals
            Console.WriteLine("We try to equals");
            string selectedOption = dropDown.GetSelectedOption();
            Assert.True(selectedOption.Equals("Option 2"),
                $"Option 2 is not selected. Instead selected - {selectedOption}");

            Console.WriteLine("--------------OK!------------");



        }
    }
}
