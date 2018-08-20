using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.DownloadPdf.FinalizeDownload
{
    public class FinalizePdfDownloadPage : BaseOmadaPage<FinalizePdfDownloadMap>
    {
        public void DownloadFile()
        {
            Map.DownloadLink.Click();
        }
    }
}