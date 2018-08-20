using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.SearchResults;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class ArticleSearchResultsPageAssert : AssertWithLog4Net
    {
        public static void ArticleWasFound(SearchResultsPage searchResultsPage, string expectedArticleTitle)
        {
            try
            {
                Assert.Contains(expectedArticleTitle, searchResultsPage.GetFoundArticleTitles());
            }
            catch (Exception e)
            {
                LogErrorAndThrowException(e, "Expected article title was not found in search results!");
            }
        }

        public static void NumberOfSearchResulstHigherThan(SearchResultsPage searchResultsPage, int expectedNumberOfSearchResults)
        {
            try
            {
                Assert.True(searchResultsPage.GetNumberOfSearchResults() > expectedNumberOfSearchResults);
            }
            catch(Exception e)
            {
                var errorMessage = $"Number of search results is not higher than expected. " +
                    $"Expected: {expectedNumberOfSearchResults}, " +
                    $"current: { searchResultsPage.GetNumberOfSearchResults()}";

                LogErrorAndThrowException(e, errorMessage);
            }
        }
    }
}