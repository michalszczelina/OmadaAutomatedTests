using OpenQA.Selenium;
using SeleniumOmadaTest.Pages.Implementations.Base;

namespace SeleniumOmadaTest.Pages.Implementations.Home
{
    public class HomeMap : BaseOmadaMap
    {
        public IWebElement SliderContent => Driver.FindElement(By.ClassName("slider__heading"));
    }
}