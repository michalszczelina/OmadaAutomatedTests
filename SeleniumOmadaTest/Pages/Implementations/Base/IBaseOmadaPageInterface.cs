using SeleniumOmadaTest.Pages.Common.Cookie;
using SeleniumOmadaTest.Pages.Common.FooterRow;
using SeleniumOmadaTest.Pages.Common.Header;
using SeleniumOmadaTest.Pages.Common.Navigation;
using SeleniumOmadaTest.Pages.Common.Serach;
using SeleniumOmadaTest.Pages.Common.TopNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumOmadaTest.Pages.Implementations.Base
{
    public interface IBaseOmadaPageInterface
    {
        CookieInformationBar CookieBar { get; }

        FooterRowBar FooterRowBar { get; }

        HeaderMenu HeaderMenu { get; }

        NavigationBar NavigationBar { get; }

        SearchHeader SearchHeader { get; }

        TopNavigationBar TopNavigationBar { get; }

        bool IsCookieBarDisplayed();
    }
}