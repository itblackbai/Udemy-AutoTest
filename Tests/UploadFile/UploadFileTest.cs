using FirstAutoTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.UploadFile
{
    public class UploadFileTest : BaseTest
    {
        [Test]
        public void ImageUploadTest()
        {
            Console.WriteLine("Starting Image Upload Test ");

            Console.WriteLine("Open page");
            //Open page
            WelcomPageObject welcomPage = new WelcomPageObject(_driver);
            welcomPage.OpenPage();
            Console.WriteLine("--------------OK!------------");
           


            //Click on form 
            Console.WriteLine("Click on form");
            FileUploadPage fileUpload = welcomPage.ClickFileUpload();
            Console.WriteLine("--------------OK!------------");
            

            //Select file
            Console.WriteLine("Select file");
            string fileName = "Logo.jpg";
            fileUpload.SelectFile(fileName);
            Console.WriteLine("--------------OK!------------");
           

            //Push button
            Console.WriteLine("Push button");
            fileUpload.PushUploadButton();
            Console.WriteLine("--------------OK!------------");
          

            // GET uploaded file
            Console.WriteLine("GET uploaded file");
            string fileNames = fileUpload.GetUploadedFilesNames();
            Console.WriteLine("--------------OK!------------");


            Console.WriteLine("Verification");
            Assert.True(fileName.Contains(fileNames),
                "Our file (" + fileName + ") is not uploaded");
            Console.WriteLine("--------------OK!------------");


        }
    }
}
