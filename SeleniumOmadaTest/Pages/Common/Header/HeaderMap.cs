using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Header
{
    public class HeaderMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.ClassName("header__function-nav--right"));

        public IWebElement ContactButton => MainDiv.FindElement(By.CssSelector("a[href$='/company/contact']"));
    }
}