using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Navigation.Menus.BusinessValue
{
    public class BusinessValueMenu : BasePageElement<BusinessValueMap>
    {
        public void NavigateToSecurityPage()
        {
            Map.SecurityLink.Click();
        }
    }
}