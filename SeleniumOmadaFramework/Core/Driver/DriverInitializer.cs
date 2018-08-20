using Autofac;
using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Configuration;
using SeleniumOmadaFramework.Core.IoC;
using System;

namespace SeleniumOmadaFramework.Core.Driver
{
    public static class DriverManager
    {
        private static IContainer BuildContainer
        {
            get
            {
                var builder = new ContainerBuilder();
                builder.RegisterModule<CommonModule>();

                return builder.Build();
            }
        }

        public static void CloseBrowser()
        {
            DriverContainer.Driver.Quit();
        }

        public static void StartBrowserAndGoToUrl(string url)
        {
            var driver = BuildContainer.Resolve<IWebDriver>();

            driver.Manage().Timeouts().ImplicitWait = ConfigReader.SeleniumImplicitWaitTimeout;
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(url);

            DriverContainer.Driver = driver;
        }
    }
}