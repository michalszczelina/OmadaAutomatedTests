using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Cases
{
    public class CasesPage : BaseOmadaPage<CasesMap>
    {
        public void GoToPdfDownload(string companyName)
        {
            var link = Map.GetDownloadLinkByCompanyName(companyName);
            link.Click();
        }
    }
}