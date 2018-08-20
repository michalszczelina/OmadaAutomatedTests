using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Implementations.DownloadPdf.UnlockSlider
{
    public class UnlockSliderMap : BasePageElementMap
    {
        public IWebElement MainDiv => Driver.FindElement(By.Id("bgSlider"));
    }
}