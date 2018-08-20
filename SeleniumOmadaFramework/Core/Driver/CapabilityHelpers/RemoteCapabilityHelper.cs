using OpenQA.Selenium.Remote;

namespace SeleniumOmadaFramework.Core.Driver.CapabilityHelpers
{
    public static class RemoteCapabilityHelper
    {
        public static DesiredCapabilities GetRemoteChromeCapabilities()
        {
            var chromeOptions = ChromeOptionsHelper.GetChromeOptions();
            var desiredCapabilities = (DesiredCapabilities)chromeOptions.ToCapabilities();
            desiredCapabilities.SetCapability("browserName", "chrome");

            return desiredCapabilities;
        }

        public static DesiredCapabilities GetRemoteFirefoxCapabilities()
        {
            var profile = FirefoxOptionsHelper.GetFirefoxOptions();
            var desiredCapabilities = (DesiredCapabilities)profile.ToCapabilities();
            desiredCapabilities.SetCapability("browserName", "firefox");

            return desiredCapabilities;
        }
    }
}