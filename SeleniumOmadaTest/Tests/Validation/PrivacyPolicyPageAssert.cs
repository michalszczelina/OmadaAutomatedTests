using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.PrivacyPolicy;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class PrivacyPolicyPageAssert : AssertWithLog4Net
    {
        public static void DisplayedHeadingEquals(PrivacyPolicyPage privacyPolicyPage, string expectedHeadingText)
        {
            try
            {
                Assert.AreEqual(expectedHeadingText, privacyPolicyPage.GetHeadingText());
            }
            catch(Exception e)
            {
                LogErrorAndThrowException(e, "Displayed heading text on Provacy Policy page is incorrect!");
            }
        }
    }
}