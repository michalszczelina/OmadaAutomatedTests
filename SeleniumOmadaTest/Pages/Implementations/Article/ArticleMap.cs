using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Article
{
    public class ArticleMap : BaseOmadaMap
    {
        public IWebElement ArticleHeader => Driver.FindElement(By.ClassName("text__heading"));

        public IWebElement ArticleContent => Driver.FindElement(By.Id("content"));
    }
}