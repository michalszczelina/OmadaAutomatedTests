using NUnit.Framework;
using SeleniumOmadaTest.Tests.Validation;

namespace SeleniumOmadaTest.Tests
{
    [Parallelizable]
    public class LoadHomePageTests : BaseTest
    {
        [Test]
        public void LoadHomePage()
        {
            const string expectedTextOnSliderHeader = "Grow your Digital Business Securely and Efficiently";
            const string expectedPageUrl = "https://www.omada.net/";

            var homePage = PageFactory.HomePage;
            HomePageAssert.HomePageLoadedCorrectly(homePage, expectedPageUrl, expectedTextOnSliderHeader);
        }
    }
}