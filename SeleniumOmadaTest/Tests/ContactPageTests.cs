using NUnit.Framework;
using SeleniumOmadaFramework.Core.Configuration;
using SeleniumOmadaTest.Pages.Implementations.Contact.Enums;
using SeleniumOmadaTest.Tests.Validation;

namespace SeleniumOmadaTest.Tests
{
    [Parallelizable]
    public class ContactPageTests : BaseTest
    {
        [Test]
        public void ContactPageTest()
        {
            var screenshotLocation = ConfigReader.ScreenshotsLocation;

            var homePage = PageFactory.HomePage;
            homePage.TopNavigationBar.NavigateToContactPage();

            var contactPage = PageFactory.ContactsPage;
            ContactPageAssert.SelectedTabIsEqual(contactPage, "Denmark");
            contactPage.TakeScreenshot(screenshotLocation, "Denmark selected");

            contactPage.SelectCountry(ContactCountries.USWest);
            ContactPageAssert.SelectedTabIsEqual(contactPage, "U.S. West");
            contactPage.TakeScreenshot(screenshotLocation, "U.S West selected");

            contactPage.HoverCountry(ContactCountries.Germany);
            contactPage.TakeScreenshot(screenshotLocation, "Germany hovered by mouse");
        }
    }
}