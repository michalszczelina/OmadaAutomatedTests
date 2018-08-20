using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.Home;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class HomePageAssert : AssertWithLog4Net
    {
        public static void HomePageLoadedCorrectly(HomePage homePage, string expectedPageUrl, string expectedTextOnSliderHeader)
        {
            try
            {
                StringAssert.Contains(expectedPageUrl, homePage.GetUrl());
                Assert.AreEqual(expectedTextOnSliderHeader, homePage.GetSliderHeaderText());
            }
            catch(Exception e)
            {
                LogErrorAndThrowException(e, "Home Page was not loaded correctly!");
            }
        }
    }
}