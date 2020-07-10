using OpenQA.Selenium;

namespace ScreenPlay.Actions
{
    public class Accept
    {
        public static bool Alert(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
    }
}
