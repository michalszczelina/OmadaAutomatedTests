using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Header
{
    public class HeaderMenu : BasePageElement<HeaderMap>
    {
        public void NavigateToContacts()
        {
            this.Map.ContactButton.Click();
        }
    }
}