using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutoTest
{
    public class HoversPage : BaseObjectPage
    {
        public HoversPage(IWebDriver driver) : base(driver)
        {
        }
        private By AvatarLocator = By.XPath("//div[@class='figure']");
        private By ViewProfileLinkLocator = By.XPath(".//a[contains(text(),'View profile')]");



        public void OpenUserProfile(int i)
        {
            IList<IWebElement> avatars = _driver.FindElements(AvatarLocator);
            IWebElement specifiedUserAvatar = avatars[i - 1];
            HoverOverElement(specifiedUserAvatar);
            specifiedUserAvatar.FindElement(ViewProfileLinkLocator).Click();
        }

    }
}
