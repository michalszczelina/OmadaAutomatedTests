using OpenQA.Selenium;
using SeleniumOmadaFramework.Pages.Implementations.Base;
using SeleniumOmadaTest.Pages.Common.Cookie;
using SeleniumOmadaTest.Pages.Common.FooterRow;
using SeleniumOmadaTest.Pages.Common.Header;
using SeleniumOmadaTest.Pages.Common.Navigation;
using SeleniumOmadaTest.Pages.Common.Serach;
using SeleniumOmadaTest.Pages.Common.TopNavigation;
using System;

namespace SeleniumOmadaTest.Pages.Implementations.Base
{
    public class BaseOmadaPage<TMap> : BasePage<BaseOmadaMap>, IBaseOmadaPageInterface where TMap : BaseMap, new()
    {
        public CookieInformationBar CookieBar => new CookieInformationBar();

        public FooterRowBar FooterRowBar => new FooterRowBar();

        public HeaderMenu HeaderMenu => new HeaderMenu();

        public NavigationBar NavigationBar => new NavigationBar();

        public SearchHeader SearchHeader => new SearchHeader();

        public TopNavigationBar TopNavigationBar => new TopNavigationBar();

        protected new TMap Map => new TMap();

        public bool IsCookieBarDisplayed()
        {
            return CookieBar.IsDisplayed();
        }
    }
}