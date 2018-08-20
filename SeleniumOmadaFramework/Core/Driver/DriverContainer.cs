using OpenQA.Selenium;
using System.Threading;

namespace SeleniumOmadaFramework.Core.Driver
{
    public static class DriverContainer
    {
        private static readonly ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                return driver.Value;
            }
            set
            {
                driver.Value = value;
            }
        }
    }
}