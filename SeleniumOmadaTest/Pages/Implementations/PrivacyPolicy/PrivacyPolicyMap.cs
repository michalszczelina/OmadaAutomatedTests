using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.PrivacyPolicy
{
    public class PrivacyPolicyMap : BaseOmadaMap
    {
        public IWebElement HeadingText => Driver.FindElement(By.ClassName("text__heading"));
    }
}