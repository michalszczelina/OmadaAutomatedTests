using NUnit.Framework;
using SeleniumOmadaTest.Tests.Validation;

namespace SeleniumOmadaTest.Tests
{
    [Parallelizable]
    public class SearchForArticleTests : BaseTest
    {
        [Test]
        public void QuickSearchForArticle()
        {
            const string textToSearch = "gartner";
            
            const string expectedArticleTitle = "There is Safety in Numbers";

            var homePage = PageFactory.HomePage;
            homePage.CookieBar.Close();
            homePage.SearchHeader.Search(textToSearch);

            var searchResultsPage = PageFactory.SearchResultsPage;
            ArticleSearchResultsPageAssert.NumberOfSearchResulstHigherThan(searchResultsPage, 1);

            var foundArticleTitles = searchResultsPage.GetFoundArticleTitles();
            ArticleSearchResultsPageAssert.ArticleWasFound(searchResultsPage, expectedArticleTitle);
        }

        [Test]
        public void OpenArticleFromQuickSearchResults()
        {
            const string textToSearch = "gartner";

            const string articleTitleToOpen = "Gartner IAM Summit 2016 - London";

            const string articleContentFragment = "Omada is a sponsor at the Gartner IAM Summit 2016 in London, " +
                "UK. The IAM Summit takes place on March 14-15 at the Park Plaza, Westminster Bridge.";

            var homePage = PageFactory.HomePage;
            homePage.CookieBar.Close();
            homePage.SearchHeader.Search(textToSearch);

            var searchResultsPage = PageFactory.SearchResultsPage;
            ArticleSearchResultsPageAssert.NumberOfSearchResulstHigherThan(searchResultsPage, 1);
            searchResultsPage.OpenArticle(articleTitleToOpen);

            var articlePage = PageFactory.ArticlePage;
            ArticlePageAssert.ArticleContainsGivenFragment(articlePage, articleContentFragment);
        }

        [Test]
        public void SearchForArticleInNews()
        {
            const string expectedArticleTitle = "Gartner IAM Summit 2016 - London";

            var homePage = PageFactory.HomePage;
            homePage.CookieBar.Close();
            homePage.NavigationBar.More.NavigateToNews();

            var newsPage = PageFactory.NewsPage;
            NewsPageAssert.ArticleWasFound(newsPage, expectedArticleTitle);
        }
    }
}