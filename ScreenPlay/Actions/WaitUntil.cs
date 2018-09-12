using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Actions
{
    public class WaitUntil
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            bool elementPresent = false;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(drv => drv.FindElement(locator));
                elementPresent = true;
            }
            catch { }

            return elementPresent;
        }
    }
}
