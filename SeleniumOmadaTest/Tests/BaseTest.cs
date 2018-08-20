using log4net.Config;
using NUnit.Framework;
using SeleniumOmadaFramework.Core.Configuration;
using SeleniumOmadaFramework.Core.Driver;
using SeleniumOmadaTest.Pages.Factory;
using System.IO;

namespace SeleniumOmadaTest.Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected PageFactory PageFactory { get; private set; }

        [SetUp]
        public void TestSetup()
        {
            var homePageUrl = ConfigReader.HomePageUrl;
            DriverManager.StartBrowserAndGoToUrl(homePageUrl);

            PageFactory = new PageFactory();
        }

        [OneTimeSetUp]
        public void ConfigureLog4Net()
        {
            XmlConfigurator.Configure();
        }

        [TearDown]
        public void AfterTest()
        {
            DriverManager.CloseBrowser();
        }

        protected void CleanupDownloadFolder()
        {
            var directoryInfo = new DirectoryInfo(@"C:\SeleniumDownloads");

            foreach(var file in directoryInfo.GetFiles())
            {
                file.Delete();
            }
        }
    }
}