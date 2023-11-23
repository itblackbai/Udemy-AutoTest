using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace FirstAutoTest
{
    public class KeyPressPage : BaseObjectPage
    {
        public KeyPressPage(IWebDriver driver) : base(driver)
        {
        }


        private By body = By.XPath("//body");
        private By resultTextLocator = By.Id("result");
        
        
        public void PressKey(string key)
        {
            Actions action = new Actions(_driver);
            action.SendKeys(Find(body), key).Perform();
        }

        public void PressKeyWithActions(string key)
        {
            Actions action = new Actions(_driver);
            action.SendKeys(key).Build().Perform(); 
        }


        public string GetResultText()
        {
            string result = Find(resultTextLocator).Text;
            Thread.Sleep(1000);
            Console.WriteLine("Result text: " + result);
            return result;
        }
    }
}
