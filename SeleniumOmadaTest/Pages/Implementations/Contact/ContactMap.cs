using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Contact
{
    public class ContactMap : BaseOmadaMap
    {
        public IWebElement HeadLine => Driver.FindElement(By.Id("brick-751"));
    }
}