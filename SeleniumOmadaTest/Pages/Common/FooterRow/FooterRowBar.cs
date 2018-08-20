using SeleniumOmadaFramework.Core.Extensions;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Common.FooterRow
{
    public class FooterRowBar : BasePageElement<FooterRowMap>
    {
        public void NavigateToCases()
        {
            Map.CasesLink.Click();
        }
    }
}