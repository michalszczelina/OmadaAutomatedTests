using NUnit.Framework;
using SeleniumOmadaFramework.Core.Configuration;
using SeleniumOmadaTest.TestData;
using SeleniumOmadaTest.Tests.Validation;
using System;
using System.Threading;

namespace SeleniumOmadaTest.Tests
{
    public class DownloadPdfTests : BaseTest
    {
        [SetUp]
        public void SetupForFileDownloadTests()
        {
            CleanupDownloadFolder();
        }

        [Test]
        public void DownloadCasesPdf()
        {
            const string expectedFileName = "Omada+Case+Takeda.pdf";
            var downloadLocation = ConfigReader.FileDownloadLocation;
            var downloadPdfData = DownloadPdfDataRepository.DownloadPdfData;

            var homePage = PageFactory.HomePage;
            homePage.CookieBar.Close();
            homePage.FooterRowBar.NavigateToCases();

            var casesPage = PageFactory.CasesPage;
            casesPage.GoToPdfDownload("takeda");

            var downloadPdfPage = PageFactory.DownloadPdfPage;
            downloadPdfPage.FillRequiredDataAndClickDownloadButton(downloadPdfData);

            var finalizeDownloadPage = PageFactory.FinalizePdfDownloadPage;
            finalizeDownloadPage.DownloadFile();

            Thread.Sleep(5000);

            PdfFileDownloadAssert.FileDownloaded(expectedFileName, downloadLocation, TimeSpan.FromSeconds(60));
        }
    }
}