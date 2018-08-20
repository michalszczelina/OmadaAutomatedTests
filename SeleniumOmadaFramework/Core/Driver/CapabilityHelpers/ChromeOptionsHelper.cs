using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumOmadaFramework.Core.Driver.CapabilityHelpers
{
    public static class ChromeOptionsHelper
    {
        public static ChromeOptions GetChromeOptions()
        {
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference("download.default_directory", @"C:\SeleniumDownloads");

            return chromeOptions;
        }
    }
}