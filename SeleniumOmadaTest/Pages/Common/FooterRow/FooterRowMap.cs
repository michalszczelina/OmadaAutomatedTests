using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.FooterRow
{
    public class FooterRowMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.ClassName("footer__container--bottom"));

        public IWebElement CasesLink => MainDiv.FindElement(By.CssSelector("a[href$='/more/customers/cases']"));
    }
}