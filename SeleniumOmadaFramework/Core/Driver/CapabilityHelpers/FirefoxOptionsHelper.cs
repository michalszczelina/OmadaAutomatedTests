using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SeleniumOmadaFramework.Core.Driver.CapabilityHelpers
{
    public static class FirefoxOptionsHelper
    {
        public static FirefoxOptions GetFirefoxOptions()
        {
            var firefoxOptions = new FirefoxOptions();

            firefoxOptions.SetPreference("browser.download.folderList", 2);
            firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", false);
            firefoxOptions.SetPreference("browser.download.dir", @"C:\SeleniumDownloads");
            firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", false);
            firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream");
            firefoxOptions.SetPreference("browser.helperApps.neverAsk.openFile", "application/octet-stream");
            firefoxOptions.SetPreference("pdfjs.disabled", true);
            firefoxOptions.SetPreference("browser.download.useDownloadDir", true);

            return firefoxOptions;
        }
    }
}