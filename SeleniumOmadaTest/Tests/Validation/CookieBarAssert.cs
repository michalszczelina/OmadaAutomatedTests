using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.Base;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class CookieBarAssert : AssertWithLog4Net
    {
        public static void CookieBarIsDisplayedOnPage(IBaseOmadaPageInterface page)
        {
            try
            {
                Assert.True(page.CookieBar.IsDisplayed());
            }
            catch(Exception e)
            {
                LogErrorAndThrowException(e, "Cookie bar was expected to be displayed on page, but it was not displayed!");
            }
        }

        public static void CookieBarIsNotDisplayedOnPage(IBaseOmadaPageInterface page)
        {
            try
            {
                Assert.False(page.CookieBar.IsDisplayed());
            }
            catch (Exception e)
            {
                LogErrorAndThrowException(e, "Cookie bar was not expected to be displayed on page, but it was displayed!");
            }
        }
    }
}