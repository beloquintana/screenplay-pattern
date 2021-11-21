using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ScreenPlay.Actions
{
    public class WaitUntil
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
