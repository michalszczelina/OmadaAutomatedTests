using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;
using System.Collections.ObjectModel;

namespace SeleniumOmadaTest.Pages.Implementations.News
{
    public class NewsMap : BaseOmadaMap
    {
        private IWebElement ContentDiv => Driver.FindElement(By.Id("content"));

        public ReadOnlyCollection<IWebElement> GetArticleTitleHeaders() => Driver.FindElements(By.ClassName("cases__heading"));
    }
}