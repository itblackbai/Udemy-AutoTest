using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FirstAutoTest
{
    public class BaseObjectPage
    {
        protected IWebDriver _driver;

        public BaseObjectPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Open url
        protected void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        //Find element using locatore
        protected IWebElement Find(By locator)
        {
            return _driver.FindElement(locator);
        }
        // Click on element with given locator when its visible 
        
        protected void Click(By locator)
        {
            WaitForVisibilityOf(locator, 5);
            Find(locator).Click();
        }
        
        // Type given text into element with given locator 
        protected void Type(string text, By locator)
        {
            WaitForVisibilityOf(locator, 5);
            Find(locator).SendKeys(text);
        }
        public string GetCurrentlyUrl()
        {
            return _driver.Url;
        }

        public string GetCurrentlyPageSource()
        {
            return _driver.PageSource;
        }
    
      	     
        private void WaitFor(Func<IWebDriver, IReadOnlyCollection<IWebElement>> condition, int? timeOutInSeconds)
        {
            timeOutInSeconds = timeOutInSeconds != null ? timeOutInSeconds : 30;
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeOutInSeconds.Value));
            wait.Until(condition);
        }

    
        protected void WaitForVisibilityOf(By locator, params int[] timeOutInSeconds)
        {
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitFor(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator),
                            (timeOutInSeconds.Length > 0 ? timeOutInSeconds[0] : (int?)null));
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
        }
        

        // Wait for alert present and then switch to id 
        protected IAlert SwitchToAlert()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.AlertIsPresent());
            return _driver.SwitchTo().Alert();  
        }
        public string GetCurrentPageTitle()
        {
            return _driver.Title;
        }

        //Switching to new window
        /*
         * We save the identifier of the current window (firstWindow).
        We get all identifiers of windows open in the browser (allWindows).
        We create an iterator for viewing these identifiers (windowsIterator).
        We start a cycle that goes through all the windows.
        We switch the context to each window, if it is not the current window.
        We check whether the title of the current page is equal to the expected title (expectedTitle).
        If the condition in point 6 is fulfilled, we exit the loop.
        */
        public void SwitchToWindowWithTitle(string expectedTitle)
        {
            // Switching to new window
            string firstWindow = _driver.CurrentWindowHandle;

            IReadOnlyCollection<string> allWindows = _driver.WindowHandles;
            IEnumerator<string> windowsIterator = allWindows.GetEnumerator();

            while (windowsIterator.MoveNext())
            {
                string windowHandle = windowsIterator.Current;
                if (!windowHandle.Equals(firstWindow))
                {
                    _driver.SwitchTo().Window(windowHandle);
                    if (GetCurrentPageTitle().Equals(expectedTitle))
                    {
                        break;
                    }
                }
            }
        }


        //Switch to IFrame using it's locator // for WYSIWYG
        protected void SwitchToFrame(By frameLocator)
        {
            _driver.SwitchTo().Frame(Find(frameLocator));
        }


        public void ScrollToBottom()
        {
            Console.WriteLine("Scrolling to the bottom of the page");
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)_driver;
            javaScript.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }


        protected void PerformDragAndDrop(By from, By to)
        {

            //One
             //Action action = new Action(_driver);
            // action.DragAndDrop(Find(from), Find(to)).Build().Perform();


            //Two
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
            jsExecutor.ExecuteScript(
                    "function createEvent(typeOfEvent) {\n" + "var event =document.createEvent(\"CustomEvent\");\n"
                            + "event.initCustomEvent(typeOfEvent,true, true, null);\n" + "event.dataTransfer = {\n"
                            + "data: {},\n" + "setData: function (key, value) {\n" + "this.data[key] = value;\n" + "},\n"
                            + "getData: function (key) {\n" + "return this.data[key];\n" + "}\n" + "};\n"
                            + "return event;\n" + "}\n" + "\n" + "function dispatchEvent(element, event,transferData) {\n"
                            + "if (transferData !== undefined) {\n" + "event.dataTransfer = transferData;\n" + "}\n"
                            + "if (element.dispatchEvent) {\n" + "element.dispatchEvent(event);\n"
                            + "} else if (element.fireEvent) {\n" + "element.fireEvent(\"on\" + event.type, event);\n"
                            + "}\n" + "}\n" + "\n" + "function simulateHTML5DragAndDrop(element, destination) {\n"
                            + "var dragStartEvent =createEvent('dragstart');\n"
                            + "dispatchEvent(element, dragStartEvent);\n" + "var dropEvent = createEvent('drop');\n"
                            + "dispatchEvent(destination, dropEvent,dragStartEvent.dataTransfer);\n"
                            + "var dragEndEvent = createEvent('dragend');\n"
                            + "dispatchEvent(element, dragEndEvent,dropEvent.dataTransfer);\n" + "}\n" + "\n"
                            + "var source = arguments[0];\n" + "var destination = arguments[1];\n"
                            + "simulateHTML5DragAndDrop(source,destination);",
                    Find(from), Find(to));
        }


        protected void HoverOverElement(IWebElement element)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(element).Build().Perform();
        }


        protected void PressesKey(By locator, string key)
        {
            Find(locator).SendKeys(key);
        }

    }
}
