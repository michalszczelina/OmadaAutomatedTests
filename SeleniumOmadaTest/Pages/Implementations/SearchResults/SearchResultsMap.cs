using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Extensions;
using SeleniumOmadaTest.Pages.Implementations.Base;
using System.Collections.ObjectModel;

namespace SeleniumOmadaTest.Pages.Implementations.SearchResults
{
    public class SearchResultsMap : BaseOmadaMap
    {
        private IWebElement SearchResultsContentDiv => Driver.FindElement(By.ClassName("search-results__content"));
        
        public ReadOnlyCollection<IWebElement> GetArticleLinksFromSearchResults()
        {
            return SearchResultsContentDiv.GetAllLinks();
        }
    }
}