using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.Article;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class ArticlePageAssert : AssertWithLog4Net
    {
        public static void ArticleContainsGivenFragment(ArticlePage articlePage, string expectedArticleFragment)
        {
            try
            {
                StringAssert.Contains(expectedArticleFragment, articlePage.GetArticleContentText());
            }
            catch(Exception e)
            {
                LogErrorAndThrowException(e, "Article does not contain expected text fragment!");
            }
        }
    }
}