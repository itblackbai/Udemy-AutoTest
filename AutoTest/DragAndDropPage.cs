using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class DragAndDropPage : BaseObjectPage
    {
        public DragAndDropPage(IWebDriver driver) : base(driver)
        {
        }
        private By columnA = By.Id("column-a");
        private By columnB = By.Id("column-b");

        /** Drag A box and drop it on B box */
        public void DragAtoB()
        {
            Console.WriteLine("Drag and drop A box on B box");
            PerformDragAndDrop(columnA, columnB);
        }

        public string GetColumnAText()
        {
            string text = Find(columnA).Text;
            Console.WriteLine("Column A Text: " + text);
            return text;
        }

        public string GetColumnBText()
        {
            string text = Find(columnB).Text;
            Console.WriteLine("Column B Text: " + text);
            return text;
        }
    }
}
