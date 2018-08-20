using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace SeleniumOmadaFramework.Core.Extensions
{
    public static class SeleniumWebDriverExtensions
    {
        public static void CloseCurrentTab(this IWebDriver driver, TimeSpan waitTimeout)
        {
            int initialNumberOfTabs = driver.GetNumberOfOpenTabs();
            var timeoutTime = DateTime.Now.Add(waitTimeout);
            var currentTime = DateTime.Now;

            driver.Close();

            while (DateTime.Compare(currentTime, timeoutTime) < 0)
            {
                if (driver.GetNumberOfOpenTabs() < initialNumberOfTabs)
                {
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    return;
                }

                Thread.Sleep(500);
            }

            throw new Exception("Timed out waiting for browser tab close!");
        }

        public static void EnterText(this IWebElement element, string text)
        {
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }

        public static ReadOnlyCollection<IWebElement> GetAllLinks(this IWebElement element)
        {
            return element.FindElements(By.TagName("a"));
        }

        public static int GetNumberOfOpenTabs(this IWebDriver driver)
        {
            return driver.WindowHandles.Count;
        }

        public static void HoverElement(this IWebDriver driver, IWebElement element)
        {
            new Actions(driver)
                .MoveToElement(element)
                .Perform();
        }

        public static void OpenLinkInNewTab(this IWebDriver driver, IWebElement link, TimeSpan waitTimeout)
        {
            int initialNumberOfTabs = driver.GetNumberOfOpenTabs();
            var timeoutTime = DateTime.Now.Add(waitTimeout);
            var currentTime = DateTime.Now;

            new Actions(driver)
                .KeyDown(Keys.Control)
                .Click(link)
                .KeyUp(Keys.Control)
                .Perform();

            while(DateTime.Compare(currentTime, timeoutTime) < 0)
            {
                if (driver.GetNumberOfOpenTabs() > initialNumberOfTabs)
                {
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    return;
                }

                Thread.Sleep(500);
            }

            throw new Exception("Timed out waiting for new browser tab!");
        }

        public static void ScrollToElement(this IWebDriver driver, IWebElement element)
        {
            new Actions(driver)
                .MoveToElement(element)
                .Perform();
        }
    }
}