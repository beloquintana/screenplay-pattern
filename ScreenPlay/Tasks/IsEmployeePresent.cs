using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;

namespace ScreenPlay.Tasks
{
    public class IsEmployeePresent
    {
        public static bool Form(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver, EmployeeUI.Form);
        }
    }
}
