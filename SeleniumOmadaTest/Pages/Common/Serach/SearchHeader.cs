using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Extensions;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.Serach
{
    public class SearchHeader : BasePageElement<SearchMap>
    {
        public void Search(string searchText)
        {
            Map.SearchInput.EnterText(searchText);
            Map.SearchInput.SendKeys(Keys.Enter);
        }
    }
}