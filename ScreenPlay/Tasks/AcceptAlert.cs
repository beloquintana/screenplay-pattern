using OpenQA.Selenium;
using ScreenPlay.Actions;

namespace ScreenPlay.Tasks
{
    public class AcceptAlert
    {
        public static bool Success(IWebDriver driver)
        {
            return Accept.Alert(driver);
        }
    }
}
