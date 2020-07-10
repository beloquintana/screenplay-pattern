using OpenQA.Selenium;

namespace ScreenPlay.Actions
{
    public class Enter
    {
        public static void Text(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
    }
}
