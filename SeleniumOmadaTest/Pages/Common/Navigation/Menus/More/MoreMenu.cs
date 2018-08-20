using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Navigation.Menus.More
{
    public class MoreMenu : BasePageElement<MoreMap>
    {
        public void NavigateToNews()
        {
            Map.NewsLink.Click();
        }
    }
}