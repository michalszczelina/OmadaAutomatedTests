using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Driver;

namespace SeleniumOmadaFramework.Pages.Implementations.Base
{
    public abstract class BaseMap
    {
        protected IWebDriver Driver => DriverContainer.Driver;
    }
}