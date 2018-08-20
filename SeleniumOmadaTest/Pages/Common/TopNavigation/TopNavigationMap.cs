using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;
using System.Linq;

namespace SeleniumOmadaTest.Pages.Common.TopNavigation
{
    public class TopNavigationMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.ClassName("header__function-nav--right"));

        public IWebElement ContactButton => MainDiv.FindElements(By.ClassName("header__menuitem--function-nav"))[0];
    }
}