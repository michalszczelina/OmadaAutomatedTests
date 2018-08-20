using OpenQA.Selenium;
using SeleniumOmadaTest.Models;
using SeleniumOmadaTest.Pages.Implementations.Base;
using SeleniumOmadaTest.Pages.Implementations.DownloadPdf.UnlockSlider;

namespace SeleniumOmadaTest.Pages.Implementations.DownloadPdf
{
    public class DownloadPdfPage : BaseOmadaPage<DownloadPdfMap>
    {
        private readonly UnlockSliderElement UnlockSlider = new UnlockSliderElement();

        public void AcceptPrivacyPolicy()
        {
            Map.AcceptCheckbox.Click();
        }

        public void FillRequiredDataAndClickDownloadButton(DownloadCasesPdfDataModel dataModel)
        {
            FillTextField(Map.JobTitleTextField, dataModel.JobTitle);
            FillTextField(Map.FirstNameTextField, dataModel.FirstName);
            FillTextField(Map.LastNameTextField, dataModel.LastName);
            FillTextField(Map.EmailTextField, dataModel.Email);
            FillTextField(Map.BusinessPhoneTextField, dataModel.BusinessPhone);
            FillTextField(Map.CompanyNameTextField, dataModel.CompanyName);

            SelectCountry(dataModel.Country);
            AcceptPrivacyPolicy();
            SlideToUnlockDownload();

            Map.DownloadPdfButton.Click();
        }

        private void FillTextField(IWebElement textField, string text)
        {
            textField.Click();
            textField.SendKeys(text);
        }

        private void SelectCountry(string countryName)
        {
            Map.CountryList.Click();
            Map.CountryList.SendKeys(countryName);
            Map.CountryList.SendKeys(Keys.Enter);
        }

        private void SlideToUnlockDownload()
        {
            UnlockSlider.SlideToUnlock();
        }
    }
}