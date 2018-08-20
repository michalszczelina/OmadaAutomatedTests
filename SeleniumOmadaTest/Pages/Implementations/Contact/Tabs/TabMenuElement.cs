using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Extensions;
using SeleniumOmadaFramework.Pages.Common.Base;
using SeleniumOmadaTest.Pages.Implementations.Contact.Enums;
using System;

namespace SeleniumOmadaTest.Pages.Implementations.Contact.Tabs
{
    public class TabMenuElement : BasePageElement<TabMenuMap>
    {
        public IWebElement GetSelectedHeader()
        {
            return Map.SelectedHeader;
        }

        public void HoverHeaderByMouse(ContactCountries country)
        {
            var elementToHover = GetHeader(country);
            Driver.HoverElement(elementToHover);
        }

        public void SelectHeader(ContactCountries country)
        {
            var elementToClick = GetHeader(country);
            elementToClick.Click();
        }

        private IWebElement GetHeader(ContactCountries country)
        {
            IWebElement element;
            
            switch (country)
            {
                case ContactCountries.Denmark:
                    element = Map.Headers[0];
                    break;

                case ContactCountries.USEast:
                    element = Map.Headers[1];
                    break;

                case ContactCountries.USWest:
                    element = Map.Headers[2];
                    break;

                case ContactCountries.Germany:
                    element = Map.Headers[3];
                    break;

                case ContactCountries.UK:
                    element = Map.Headers[4];
                    break;

                default:
                    throw new Exception($"Incorrect enum value: {country}");
            }

            return element;
        }
    }
}