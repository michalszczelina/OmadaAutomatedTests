using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.DownloadPdf.FinalizeDownload
{
    public class FinalizePdfDownloadMap : BaseOmadaMap
    {
        public IWebElement DownloadLink => Driver.FindElement(By.CssSelector("a[href$='.pdf']"));
    }
}