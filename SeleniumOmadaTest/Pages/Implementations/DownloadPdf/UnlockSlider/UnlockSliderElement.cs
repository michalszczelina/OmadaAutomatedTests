using OpenQA.Selenium.Interactions;
using SeleniumOmadaFramework.Pages.Common.Base;

namespace SeleniumOmadaTest.Pages.Implementations.DownloadPdf.UnlockSlider
{
    public class UnlockSliderElement : BasePageElement<UnlockSliderMap>
    {
        public void SlideToUnlock()
        {
            int sliderWidth = Map.MainDiv.Size.Width;
            int sliderHeight = Map.MainDiv.Size.Height;

            Map.MainDiv.Click();

            new Actions(Driver)
                .MoveToElement(Map.MainDiv, 5, sliderHeight / 2)
                .ClickAndHold()
                .MoveByOffset(sliderWidth, 0)
                .Release()
                .Perform();
        }
    }
}