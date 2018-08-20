using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Driver;
using SeleniumOmadaTest.Pages.Implementations.Article;
using SeleniumOmadaTest.Pages.Implementations.Cases;
using SeleniumOmadaTest.Pages.Implementations.Contact;
using SeleniumOmadaTest.Pages.Implementations.DownloadPdf;
using SeleniumOmadaTest.Pages.Implementations.DownloadPdf.FinalizeDownload;
using SeleniumOmadaTest.Pages.Implementations.Home;
using SeleniumOmadaTest.Pages.Implementations.News;
using SeleniumOmadaTest.Pages.Implementations.PrivacyPolicy;
using SeleniumOmadaTest.Pages.Implementations.SearchResults;

namespace SeleniumOmadaTest.Pages.Factory
{
    public class PageFactory
    {
        private IWebDriver Driver => DriverContainer.Driver;

        public ArticlePage ArticlePage => new ArticlePage();

        public CasesPage CasesPage => new CasesPage();

        public ContactPage ContactsPage => new ContactPage();

        public DownloadPdfPage DownloadPdfPage => new DownloadPdfPage();

        public FinalizePdfDownloadPage FinalizePdfDownloadPage => new FinalizePdfDownloadPage();

        public HomePage HomePage => new HomePage();

        public NewsPage NewsPage => new NewsPage();

        public PrivacyPolicyPage PrivacyPolicyPage => new PrivacyPolicyPage();

        public SearchResultsPage SearchResultsPage => new SearchResultsPage();
    }
}