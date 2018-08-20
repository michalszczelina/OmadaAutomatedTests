using Autofac;
using Autofac.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SeleniumOmadaFramework.Core.Configuration;
using SeleniumOmadaFramework.Core.Configuration.Enums;
using SeleniumOmadaFramework.Core.Driver.CapabilityHelpers;
using System;
using System.Collections.Generic;

namespace SeleniumOmadaFramework.Core.IoC
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var browser = ConfigReader.Browser;

            switch (browser)
            {
                case Browsers.Chrome:
                    RegisterLocalChromeDriver(builder);
                    break;

                case Browsers.Firefox:
                    RegisterLocalFirefoxDriver(builder);
                    break;

                case Browsers.ChromeRemote:
                    RegisterRemoteChromeDriver(builder);
                    break;

                case Browsers.FirefoxRemote:
                    RegisterRemoteFirefoxDriver(builder);
                    break;

                default:
                    throw new Exception($"Incorrect browser type: {browser}");
            }
        }

        private void RegisterLocalChromeDriver(ContainerBuilder builder)
        {
            builder.RegisterType<ChromeDriver>().As<IWebDriver>()
                        .WithParameter(new TypedParameter(typeof(ChromeOptions), ChromeOptionsHelper.GetChromeOptions()));
        }

        private void RegisterLocalFirefoxDriver(ContainerBuilder builder)
        {
            builder.RegisterType<FirefoxDriver>().As<IWebDriver>()
                        .WithParameter(new TypedParameter(typeof(FirefoxOptions), FirefoxOptionsHelper.GetFirefoxOptions()));
        }

        private void RegisterRemoteChromeDriver(ContainerBuilder builder)
        {
            var listOfParameters = new List<Parameter>
            {
                new NamedParameter("remoteAddress", ConfigReader.SeleniumHubUrl),
                new NamedParameter("desiredCapabilities", RemoteCapabilityHelper.GetRemoteChromeCapabilities()),
                new NamedParameter("commandTimeout", ConfigReader.SeleniumCommandTimeout)
            };

            builder.RegisterType<RemoteWebDriver>().As<IWebDriver>().WithParameters(listOfParameters);
        }

        private void RegisterRemoteFirefoxDriver(ContainerBuilder builder)
        {
            var listOfParameters = new List<Parameter>
            {
                new NamedParameter("remoteAddress", ConfigReader.SeleniumHubUrl),
                new NamedParameter("desiredCapabilities", RemoteCapabilityHelper.GetRemoteFirefoxCapabilities()),
                new NamedParameter("commandTimeout", ConfigReader.SeleniumCommandTimeout)
            };

            builder.RegisterType<RemoteWebDriver>().As<IWebDriver>().WithParameters(listOfParameters);
        }        
    }
}