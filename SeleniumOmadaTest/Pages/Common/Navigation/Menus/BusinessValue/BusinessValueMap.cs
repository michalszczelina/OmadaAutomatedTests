using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Navigation.Menus.BusinessValue
{
    public class BusinessValueMap : BasePageElementMap
    {
        public IWebElement SecurityLink => Driver.FindElement(By.CssSelector("a[href*='/business-value/security'"));
    }
}