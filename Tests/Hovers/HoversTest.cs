using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Hovers
{
    public class HoversTest : BaseTest
    {
        [Test]
        public void CreateHoversTest()
        {

            Console.WriteLine("Starting Hovers Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            //Click on form 
            Console.WriteLine("Click on form : ");
            HoversPage hoversPage = welcomPage.ClickHovers();
            Console.WriteLine("--------------OK!------------");


            //Click on form 
            Console.WriteLine("Open profile ");
            hoversPage.OpenUserProfile(2);
            Console.WriteLine("--------------OK!------------");


            //Verificathion
            Console.WriteLine("Verification with url");
            Assert.True(hoversPage.GetCurrentlyUrl().Contains("/users/2"),
                "Url is uncorrect");
            Console.WriteLine("--------------OK!------------");
        }

    }
}
