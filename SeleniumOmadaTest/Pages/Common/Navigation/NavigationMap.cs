using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Navigation
{
    public class NavigationMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.ClassName("header__menulist"));

        public IWebElement BusinessValueButton => MainDiv.FindElements(By.ClassName("header__menuitem--megamenu"))[0];

        public IWebElement MoreButton => MainDiv.FindElements(By.ClassName("header__menuitem--megamenu"))[4];
    }
}