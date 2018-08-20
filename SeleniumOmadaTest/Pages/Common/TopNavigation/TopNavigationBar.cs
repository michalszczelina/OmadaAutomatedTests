using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.TopNavigation
{
    public class TopNavigationBar : BasePageElement<TopNavigationMap>
    {
        public void NavigateToContactPage()
        {
            Map.ContactButton.Click();
        }
    }
}