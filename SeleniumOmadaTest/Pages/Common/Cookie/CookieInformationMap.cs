using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Cookie
{
    public class CookieInformationMap : BasePageElementMap
    {
        private IWebElement MainDiv => Driver.FindElement(By.Id("brick-43"));

        public IWebElement CloseButton => MainDiv.FindElement(By.ClassName("button--variant1"));

        public IWebElement PrivacyPolicyButton => MainDiv.FindElement(By.ClassName("cookiebar__read-more"));
    }
}