using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.HorizontalSliderTests
{
    public class HorizontalSliderTests : BaseTest
    {
        [Test]
        public void HorizontalsliderTest()
        {
            Console.WriteLine("Starting Horizontalslider Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            //Click on form 
            Console.WriteLine("Click on form : ");
            HorizontalSliderPage horizontalSlider = welcomPage.ClickHorizontal();
            Console.WriteLine("--------------OK!------------");

            // Value
            Console.WriteLine("Set value for slider");
            string value = "3,5";
            Console.WriteLine("--------------OK!------------");

            // Set slider value
            Console.WriteLine("Click on form : ");
            Thread.Sleep(2000);
            horizontalSlider.SetSliderTo(value);
            Thread.Sleep(2000);
            Console.WriteLine("--------------OK!------------");

            // Verify slider value
            Console.WriteLine("Verification");
            string sliderValue = horizontalSlider.GetSliderValue();
            Assert.True(sliderValue.Equals(value), "Range is not correct. It is: " + sliderValue);
        }
    }
}
