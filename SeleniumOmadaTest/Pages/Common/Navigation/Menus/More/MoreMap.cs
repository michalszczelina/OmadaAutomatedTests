using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Navigation.Menus.More
{
    public class MoreMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElements(By.CssSelector("a[href$='/more']"))[1].FindElement(By.XPath(".."));

        public IWebElement NewsLink => Driver.FindElements(By.CssSelector("a[href*='/more/news-events/news']"))[3];
    }
}