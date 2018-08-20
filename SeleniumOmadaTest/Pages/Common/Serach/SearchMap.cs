using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Serach
{
    public class SearchMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.ClassName("header__search"));
        
        public IWebElement SearchInput => MainDiv.FindElement(By.ClassName("header__search-input"));
    }
}