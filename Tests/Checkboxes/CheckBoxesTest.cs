using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Checkboxes
{
    public class CheckBoxesTest : BaseTest
    {
        [Test]
        public void SelectingTwoCheckBoxesTest()
        {
            Console.WriteLine("Starting SelectingTwoCheckBoxesTest");
            Console.Write("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);  
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");


            Console.WriteLine("Click on form : ");
            CheckboxPage checkbox = welcomPage.ClickCheckboxes();
            Console.WriteLine("--------------OK!------------");

            Thread.Sleep(1000);
            Console.WriteLine("Select All Checkboxes");
            checkbox.SelectAllCheckboxes();
            Console.WriteLine("--------------OK!------------");
            Thread.Sleep(1000);


            Console.WriteLine("Verify all checkboxes are checked");
            Assert.True(checkbox.AreAllCheckboxesChecked(), "Not all was cheked!");
            Console.WriteLine("--------------OK!------------");
        }
    }
}
