using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;
using System.Collections.ObjectModel;

namespace SeleniumOmadaTest.Pages.Implementations.Contact.Tabs
{
    public class TabMenuMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.ClassName("tabmenu__container"));
        
        public ReadOnlyCollection<IWebElement> Headers => MainDiv.FindElements(By.ClassName("tabmenu__menu-item"));

        public IWebElement SelectedHeader => MainDiv.FindElement(By.ClassName("selected"));
    }
}