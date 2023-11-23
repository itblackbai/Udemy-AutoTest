using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class WYSIWYGEditorPage : BaseObjectPage
    {
        public WYSIWYGEditorPage(IWebDriver driver) : base(driver)
        {
        }

        private By editorLocator = By.Id("tinymce");
        private By frame = By.TagName("iframe");


        //Get text from tinyMCE 
        public string GetEditorText()
        {
          
            SwitchToFrame(frame);
            Thread.Sleep(1000);
            string text = Find(editorLocator).Text;
            Console.WriteLine("Text from TinyMCE Editor " + text);
            return text;
        }
    }
}
