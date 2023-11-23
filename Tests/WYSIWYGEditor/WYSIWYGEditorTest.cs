using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.WYSIWYGEditor
{
    public class WYSIWYGEditorTest : BaseTest
    {
        [Test]
        public void DefaultEditorValueTests()
        {
            Console.WriteLine("Starting Default Editor Value Test");

            //Open page
            Console.WriteLine("Open page : ");
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");


            //Scrolling 
            Thread.Sleep(5000);
            welcomPage.ScrollToBottom();
            Thread.Sleep(5000);


            //Click on form 
            Console.WriteLine("Click on form : ");
            WYSIWYGEditorPage editorPage = welcomPage.ClickWYSIWYGEditor();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Get default editor text");
            string editorText = editorPage.GetEditorText();
            Console.WriteLine("--------------OK!------------");

            //Vefirication 
            Console.WriteLine("That new page contains expected text in source");
            Console.WriteLine(editorText);
            Assert.True(editorText.Equals("Your content goes here."),
                "Editor default text is not expected. It is: " + editorText);

            Console.WriteLine("--------------OK!------------");


        }
    }
}
