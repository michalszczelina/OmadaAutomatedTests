using OpenQA.Selenium;
using SeleniumOmadaFramework.Core.Driver;

namespace SeleniumOmadaFramework.Pages.Common.Base
{
    public abstract class BasePageElement<TMap> where TMap : BasePageElementMap, new()
    {
        protected IWebDriver Driver => DriverContainer.Driver;

        protected TMap Map => new TMap();
    }
}