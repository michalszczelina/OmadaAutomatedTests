using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Driver;

namespace SeleniumOmadaFramework.Pages.Common.Base
{
    public abstract class BasePageElementMap
    {
        protected IWebDriver Driver => DriverContainer.Driver;
    }
}