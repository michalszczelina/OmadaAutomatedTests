using SeleniumOmadaTest.Models;

namespace SeleniumOmadaTest.TestData
{
    public static class DownloadPdfDataRepository
    {
        public static DownloadCasesPdfDataModel DownloadPdfData => new DownloadCasesPdfDataModel
        {
            JobTitle = "Software Test Engineer",
            FirstName = "Michal",
            LastName = "Szczelina",
            Email = "michalszczelina@gmail.com",
            BusinessPhone = "123456789",
            CompanyName = "company",
            Country = "Poland"
        };
    }
}