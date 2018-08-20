using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Home
{
    public class HomePage : BaseOmadaPage<HomeMap>
    {
        public string GetSliderHeaderText()
        {
            return Map.SliderContent.Text;
        }
    }
}