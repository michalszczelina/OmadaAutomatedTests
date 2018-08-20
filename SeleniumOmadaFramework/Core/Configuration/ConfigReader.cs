using SeleniumOmadaFramework.Core.Configuration.Enums;
using System;
using System.Configuration;

namespace SeleniumOmadaFramework.Core.Configuration
{
    public static class ConfigReader
    {
        public static Browsers Browser
        {
            get
            {
                var browser = ConfigurationManager.AppSettings["Browser"];

                switch (browser)
                {
                    case "Chrome":
                        return Browsers.Chrome;
                    case "Firefox":
                        return Browsers.Firefox;
                    case "ChromeRemote":
                        return Browsers.ChromeRemote;
                    case "FirefoxRemote":
                        return Browsers.FirefoxRemote;
                    default:
                        throw new Exception($"Incorrect browser in config file: {browser}");
                }
            }
        }

        public static TimeSpan CloseBrowserTabWaitTimeout => TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["CloseBrowserTabWaitTimeout"]));

        public static string HomePageUrl => ConfigurationManager.AppSettings["HomepageUrl"];

        public static string FileDownloadLocation => ConfigurationManager.AppSettings["FileDownloadLocation"];

        public static TimeSpan NewBrowserTabWaitTimeout => TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["NewBrowserTabWaitTimeout"]));

        public static string ScreenshotsLocation => ConfigurationManager.AppSettings["ScreenshotsLocation"];

        public static TimeSpan SeleniumCommandTimeout => TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumCommandTimeout"]));

        public static Uri SeleniumHubUrl => new Uri(ConfigurationManager.AppSettings["SeleniumHubUrl"]);

        public static TimeSpan SeleniumImplicitWaitTimeout => TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumImplicitWaitTimeout"]));

        public static TimeSpan SeleniumExplicitWaitTimeout => TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["SeleniumExplicitWaitTimeout"]));
    }
}