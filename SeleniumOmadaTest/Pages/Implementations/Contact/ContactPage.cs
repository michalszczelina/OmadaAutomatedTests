using SeleniumOmadaTest.Pages.Implementations.Base;
using SeleniumOmadaTest.Pages.Implementations.Contact.Enums;
using SeleniumOmadaTest.Pages.Implementations.Contact.Tabs;

namespace SeleniumOmadaTest.Pages.Implementations.Contact
{
    public class ContactPage : BaseOmadaPage<ContactMap>
    {
        private TabMenuElement TabMenu => new TabMenuElement();
        
        public string GetHeadLineText()
        {
            var headLine = Map.HeadLine;
            return headLine.Text;
        }

        public string GetSelectedContactTab()
        {
            var selectedHeader = TabMenu.GetSelectedHeader();
            return selectedHeader.Text;
        }

        public void HoverCountry(ContactCountries country)
        {
            TabMenu.HoverHeaderByMouse(country);
        }

        public void SelectCountry(ContactCountries country)
        {
            TabMenu.SelectHeader(country);
        }
    }
}