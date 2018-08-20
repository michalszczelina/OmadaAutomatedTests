using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.PrivacyPolicy
{
    public class PrivacyPolicyPage : BaseOmadaPage<PrivacyPolicyMap>
    {
        public string GetHeadingText()
        {
            return Map.HeadingText.Text;
        }
    }
}