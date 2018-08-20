using NUnit.Framework;
using SeleniumOmadaTest.Tests.Validation;

namespace SeleniumOmadaTest.Tests
{
    [Parallelizable]
    public class CloseCookiesTests : BaseTest
    {
        [Test]
        public void CloseCookiesInformation()
        {
            var homePage = PageFactory.HomePage;

            CookieBarAssert.CookieBarIsDisplayedOnPage(homePage);
            homePage.CookieBar.Close();
            CookieBarAssert.CookieBarIsNotDisplayedOnPage(homePage);

            homePage.HeaderMenu.NavigateToContacts();
            var contactsPage = PageFactory.ContactsPage;
            CookieBarAssert.CookieBarIsNotDisplayedOnPage(contactsPage);
        }

        [Test]
        public void NavigateToPrivacyPolicyInNewTab()
        {
            const string expectedPrivacyPolicyHeadingText = "WEBSITE PRIVACY POLICY";

            var homePage = PageFactory.HomePage;
            homePage.CookieBar.OpenPrivacyPolicyInNewTab();

            var privacyPolicyPage = PageFactory.PrivacyPolicyPage;
            PrivacyPolicyPageAssert.DisplayedHeadingEquals(privacyPolicyPage, expectedPrivacyPolicyHeadingText);

            privacyPolicyPage.CookieBar.WaitToBeDisplayed();
            privacyPolicyPage.CookieBar.Close();
            privacyPolicyPage.CloseCurrentTab();

            homePage.Refresh();
            CookieBarAssert.CookieBarIsNotDisplayedOnPage(homePage);
        }
    }
}