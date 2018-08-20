using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Article
{
    public class ArticlePage : BaseOmadaPage<ArticleMap>
    {
        public string GetArticleContentText()
        {
            var articleContent = Map.ArticleContent;
            return articleContent.Text;
        }

        public string GetArticleHeaderText()
        {
            var articleHeader = Map.ArticleHeader;
            return articleHeader.Text;
        }
    }
}