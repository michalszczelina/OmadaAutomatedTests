using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Cases
{
    public class CasesMap : BaseOmadaMap
    {
        public IWebElement GetDownloadLinkByCompanyName(string companyName)
        {
            var link = Driver.FindElement(By.CssSelector($"a[href*='more/customers/cases/{companyName}-case"));
            return link;
        }
    }
}