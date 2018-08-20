using SeleniumOmadaFramework.Core.Extensions;
using SeleniumOmadaFramework.Pages.Common.Base;
using SeleniumOmadaTest.Pages.Common.Navigation.Menus.BusinessValue;
using SeleniumOmadaTest.Pages.Common.Navigation.Menus.More;
using System.Threading;

namespace SeleniumOmadaTest.Pages.Common.Navigation
{
    public class NavigationBar : BasePageElement<NavigationMap>
    {
        public BusinessValueMenu BusinessValue
        {
            get
            {
                Driver.HoverElement(Map.BusinessValueButton);
                Thread.Sleep(1000);
                return new BusinessValueMenu();
            }
        }

        public MoreMenu More
        {
            get
            {
                Driver.HoverElement(Map.MoreButton);
                Thread.Sleep(1000);
                return new MoreMenu();
            }
        }
    }
}