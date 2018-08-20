﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace SeleniumOmadaFramework.Core.Extensions
{
    public static class SeleniumWebDriverExtensions
    {
        public static void CloseCurrentTab(this IWebDriver driver)
        {
            int initialNumberOfTabs = driver.GetNumberOfOpenTabs();

            driver.Close();

            while (driver.GetNumberOfOpenTabs() == initialNumberOfTabs)
            {
                Thread.Sleep(500);
            }

            driver.SwitchTo().Window(driver.WindowHandles.Last());
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

        public static void OpenLinkInNewTab(this IWebDriver driver, IWebElement link)
        {
            int initialNumberOfTabs = driver.GetNumberOfOpenTabs();

            new Actions(driver)
                .KeyDown(Keys.Control)
                .Click(link)
                .KeyUp(Keys.Control)
                .Perform();

            while(driver.GetNumberOfOpenTabs() == initialNumberOfTabs)
            {
                Thread.Sleep(500);
            }

            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public static void ScrollToElement(this IWebDriver driver, IWebElement element)
        {
            new Actions(driver)
                .MoveToElement(element)
                .Perform();
        }
    }
}