using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class FileUploadPage : BaseObjectPage
    {
        public FileUploadPage(IWebDriver driver) : base(driver)
        {
        }

        private By ChoseFileFieldLocator = By.Id("file-upload");
        private By UploadButtonLocator = By.Id("file-submit");
        private By UploadedFilesLocator = By.Id("uploaded-files");



        /** Push Upload button */
        public void PushUploadButton()
        {
            Console.WriteLine("Clicking on upload button");
            Click(UploadButtonLocator);
        }

        /** Push Upload button */
        public void SelectFile(String fileName)
        {
            Console.WriteLine("Selecting '" + fileName + "' file from Files folder");
            // Selecting file
           
            string filePathD = $"D:\\{fileName}";
            Type(filePathD, ChoseFileFieldLocator);
            Console.WriteLine("File selected");
        }

        /** Get names of uploaded files */
        public string GetUploadedFilesNames()
        {
         
            string names = Find(UploadedFilesLocator).Text;
           
            Console.WriteLine("Uploaded files: " + names);
            return names;
        }
    }
}
