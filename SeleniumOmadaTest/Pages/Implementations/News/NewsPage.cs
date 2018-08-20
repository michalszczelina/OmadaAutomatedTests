using SeleniumOmadaTest.Pages.Implementations.Base;
using System.Collections.Generic;

namespace SeleniumOmadaTest.Pages.Implementations.News
{
    public class NewsPage : BaseOmadaPage<NewsMap>
    {
        public string[] GetArticleTitles()
        {
            var titles = new List<string>();
            var articleLinks = Map.GetArticleTitleHeaders();

            foreach (var link in articleLinks)
            {
                titles.Add(link.Text);
            }

            return titles.ToArray();
        }
    }
}