using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.News;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class NewsPageAssert : AssertWithLog4Net
    {
        public static void ArticleWasFound(NewsPage newsPage, string expectedArticleTitle)
        {
            try
            {
                Assert.Contains(expectedArticleTitle, newsPage.GetArticleTitles());
            }
            catch(Exception e)
            {
                LogErrorAndThrowException(e, "Expected article title was not found on page!");
            }
        }
    }
}