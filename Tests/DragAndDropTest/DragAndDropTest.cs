using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DragAndDropTest
{
    public class DragAndDropTest : BaseTest
    {
        [Test]
        public void DragandDropTest()
        {
            Console.WriteLine("Starting DragAndDrop Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            //Click on form 
            Console.WriteLine("Click on form : ");
            DragAndDropPage dragAndDrop = welcomPage.ClickDragAndDrop();
            Console.WriteLine("--------------OK!------------");

            //DragAtoB
            Console.WriteLine("DragAtoB ");
            dragAndDrop.DragAtoB();
            Console.WriteLine("--------------OK!------------");


            //Verify
            Console.WriteLine("Verify 1");
            string columAtext = dragAndDrop.GetColumnAText();
            Assert.True(columAtext.Equals("B"), "" +
                "Column A header should be B, but it is: " + columAtext);
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Verify 2");
            string columBText = dragAndDrop.GetColumnBText();
            Assert.True(columAtext.Equals("B"), "" +
                "Column A header should be B, but it is: " + columBText);
            Console.WriteLine("--------------OK!------------");
        }
    }
}
