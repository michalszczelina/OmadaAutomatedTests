using SeleniumOmadaTest.Pages.Implementations.Base;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumOmadaTest.Pages.Implementations.SearchResults
{
    public class SearchResultsPage : BaseOmadaPage<SearchResultsMap>
    {
        public string[] GetFoundArticleTitles()
        {
            var titles = new List<string>();
            var articleLinks = Map.GetArticleLinksFromSearchResults();

            foreach (var link in articleLinks)
            {
                titles.Add(link.Text);
            }

            return titles.ToArray();
        }

        public int GetNumberOfSearchResults()
        {
            var articleLinks = Map.GetArticleLinksFromSearchResults();
            return articleLinks.Count;
        }

        public void OpenArticle(string articleTitle)
        {
            var allLinks = Map.GetArticleLinksFromSearchResults();
            var articleLink = allLinks.FirstOrDefault(link => link.Text.EndsWith(articleTitle));
            articleLink.Click();
        }
    }
}