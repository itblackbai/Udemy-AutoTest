using FirstAutoTest;
using OpenQA.Selenium;

namespace FirstAutoTest
{
    public class WelcomPageObject : BaseObjectPage
    {
        private string pageUrl = "https://the-internet.herokuapp.com/";

        //LinkedText
        private By formAuthenticonLinkLocator = By.LinkText("Form Authentication");
        private By CheckboxesLinkLocator = By.LinkText("Checkboxes");
        private By DropdownLinkLocator = By.LinkText("Dropdown");
        private By JavaScriptAlertsLinkLocator = By.LinkText("JavaScript Alerts");
        private By MultipleWindowsLinkLocator = By.LinkText("Multiple Windows");
        private By WYSIWYGEditorLinkLocator = By.LinkText("WYSIWYG Editor");
        private By KeyPressesLinkLocator = By.LinkText("Key Presses");
        private By FileUploadLinkLocator = By.LinkText("File Upload");
        private By DragAndDropdLinkLocator = By.LinkText("Drag and Drop");
        private By HoversLinkLocator = By.LinkText("Hovers");
        private By HorizontalSliderLinkLocator = By.LinkText("Horizontal Slider");




        public WelcomPageObject(IWebDriver driver) : base(driver)
        {

        }



        //XPath 
        private IWebElement linkFormAuthentication => _driver.FindElement(By.XPath("//a[@href='/login']"));
        private IWebElement linkCheckboxes => _driver.FindElement(By.XPath("//a[@href='/checkboxes']"));


        public void OpenPage()
        {
            OpenUrl(pageUrl);
        }


        public HorizontalSliderPage ClickHorizontal()
        {
            Console.WriteLine("Open link Horizontal Page");
            Click(HorizontalSliderLinkLocator);
            return new HorizontalSliderPage(_driver);
        }

        public HoversPage ClickHovers()
        {
            Console.WriteLine("Open link Hovers Page");
            Click(HoversLinkLocator);
            return new HoversPage(_driver);
        }

        public DragAndDropPage ClickDragAndDrop()
        {
            Console.WriteLine("Open link DragAndDrop Page");
            Click(DragAndDropdLinkLocator);
            return new DragAndDropPage(_driver);
        }


        public FileUploadPage ClickFileUpload()
        {
            Console.WriteLine("Open link FileUpload Page");
            Click(FileUploadLinkLocator);
            return new FileUploadPage(_driver);
        }

        public KeyPressPage ClickKeyPress()
        {
            Console.WriteLine("Open link Key Press");
            Click(KeyPressesLinkLocator);
            return new KeyPressPage(_driver);
        }

        public CheckboxPage ClickCheckboxes()
        {
            Console.WriteLine("Open link CheckBoxes");
            Click(CheckboxesLinkLocator);
            return new CheckboxPage(_driver);
        }

        public JavaScriptAlertsPage ClickJavaScriptAlerts()
        {
            Console.WriteLine("Open link JavaScriptAlerts Page");
            Click(JavaScriptAlertsLinkLocator);
            return new JavaScriptAlertsPage(_driver);
        }

        public DropDownPage ClickDropDown()
        {
            Console.WriteLine("Open link DropDown Page");
            Click(DropdownLinkLocator);
            return new DropDownPage(_driver);
        }

        public MultipleWindowsPage ClickMultipleWindows()
        {
            Console.WriteLine("Open link MultipleWindows Page");
            Click(MultipleWindowsLinkLocator);
            return new MultipleWindowsPage(_driver);
        }

        public WYSIWYGEditorPage ClickWYSIWYGEditor()
        {
            Console.WriteLine("Open link MultipleWindows Page");
            Click(WYSIWYGEditorLinkLocator);
            return new WYSIWYGEditorPage(_driver);
        }

        public FormAuthenticationPage ClickFormAuthentication()
        {
            Console.WriteLine("Open link Form Authentication Page");
            Click(formAuthenticonLinkLocator);
            return new FormAuthenticationPage(_driver);
        }



    }
}

