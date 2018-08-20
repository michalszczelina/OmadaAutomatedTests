using NUnit.Framework;
using SeleniumOmadaTest.Pages.Implementations.Contact;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class ContactPageAssert : AssertWithLog4Net
    {
        public static void SelectedTabIsEqual(ContactPage contactPage, string expectedSelectedTab)
        {
            try
            {
                Assert.AreEqual(expectedSelectedTab, contactPage.GetSelectedContactTab());
            }
            catch(Exception e)
            {
                LogErrorAndThrowException(e, "Selected Contact tab is different than expected!");
            }
        }
    }
}