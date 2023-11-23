using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Globalization;

namespace FirstAutoTest
{
    public class HorizontalSliderPage : BaseObjectPage
    {
        public HorizontalSliderPage(IWebDriver driver) : base(driver)
        {
        }

        private By rangeLocator = By.Id("range");
        private By sliderLocator = By.TagName("input");

        /** Move slider to specified value */
        public void SetSliderTo(String value)
        {
            Console.WriteLine("Moving slider to " + value);


            // Workaround method
            // Calculate number of steps
            int steps = (int)(double.Parse(value) / 0.5);

            // Perform steps
            PressesKey(sliderLocator, Keys.Enter);
            for (int i = 0; i < steps; i++)
            {
                PressesKey(sliderLocator, Keys.ArrowRight);
            }
        }

        public string GetSliderValue()
        {
            string value = Find(rangeLocator).Text.Replace(".", ",");
            Console.WriteLine("Slider value is " + value);
            return value;
        }



    }
}
