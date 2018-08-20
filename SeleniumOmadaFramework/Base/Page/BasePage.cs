using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Driver;
using SeleniumOmadaFramework.Core.Extensions;
using System;
using System.IO;

namespace SeleniumOmadaFramework.Pages.Implementations.Base
{
    public abstract class BasePage<TMap> where TMap : BaseMap, new()
    {
        protected IWebDriver Driver => DriverContainer.Driver;

        protected TMap Map => new TMap();

        public void CloseCurrentTab()
        {
            Driver.CloseCurrentTab();
        }

        public string GetUrl()
        {
            return Driver.Url;
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        public string TakeScreenshot(string screenshotLocation, string screenName)
        {
            var testName = TestContext.CurrentContext.Test.Name;
            var currentDate = DateTime.Now.ToShortDateString();
            var currentTime = DateTime.Now.ToLongTimeString().Replace(':', '.');

            var screenshotFileName = $"{currentDate} {currentTime} [{testName}] {screenName}.png";
            var screenshotPath = Path.Combine(new string[] { screenshotLocation,  screenshotFileName});

            Directory.CreateDirectory(screenshotLocation);

            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            ss.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            return screenshotPath;
        }
    }
}