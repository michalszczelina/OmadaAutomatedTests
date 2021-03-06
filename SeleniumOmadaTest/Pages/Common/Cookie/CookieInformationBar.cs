﻿using SeleniumOmadaFramework.Core.Configuration;
using SeleniumOmadaFramework.Core.Extensions;
using SeleniumOmadaFramework.Pages.Common.Base;
using System.Threading;

namespace SeleniumOmadaTest.Pages.Common.Cookie
{
    public class CookieInformationBar : BasePageElement<CookieInformationMap>
    {
        public void Close()
        {
            Map.CloseButton.Click();
        }

        public void GoToPrivacyPolicy()
        {
            Map.PrivacyPolicyButton.Click();
        }

        public bool IsDisplayed()
        {
            return Map.CloseButton.Displayed;
        }

        public void OpenPrivacyPolicyInNewTab()
        {
            var newTabWaitTimeout = ConfigReader.NewBrowserTabWaitTimeout;
            Driver.OpenLinkInNewTab(Map.PrivacyPolicyButton, newTabWaitTimeout);
        }

        public void WaitToBeDisplayed()
        {
            while(!Map.CloseButton.Displayed)
            {
                Thread.Sleep(500);
            }
        }
    }
}