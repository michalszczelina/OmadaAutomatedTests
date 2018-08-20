using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.DownloadPdf
{
    public class DownloadPdfMap : BaseOmadaMap
    {
        public IWebElement JobTitleTextField => Driver.FindElement(By.Id("f_84ef53b4f80ee71180eac4346bac2ebc"));

        public IWebElement FirstNameTextField => Driver.FindElement(By.Id("f_7bb79f2f2aa5e61180e4c4346bac7e3c"));

        public IWebElement LastNameTextField => Driver.FindElement(By.Id("f_501281762aa5e61180e4c4346bac7e3c"));

        public IWebElement EmailTextField => Driver.FindElement(By.Id("f_511a8b932aa5e61180e4c4346bac7e3c"));

        public IWebElement BusinessPhoneTextField => Driver.FindElement(By.Id("f_5d3af1ac19a8e61180dfc4346bad20a4"));

        public IWebElement CompanyNameTextField => Driver.FindElement(By.Id("f_42b109e9c1a5e61180e4c4346bac7e3c"));

        public IWebElement CountryList => Driver.FindElement(By.Id("f_61d4da016ca6e61180dfc4346bad20a4"));

        public IWebElement AcceptCheckbox => Driver.FindElement(By.Id("f_3557f512c2a5e61180e4c4346bac7e3c"));

        public IWebElement DownloadPdfButton => Driver.FindElement(By.Id("btnSubmit"));
    }
}