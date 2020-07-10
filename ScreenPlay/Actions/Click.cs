using OpenQA.Selenium;

namespace ScreenPlay.Actions
{
    public class Click
    {
        public static void On(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
