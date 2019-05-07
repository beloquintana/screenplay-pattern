using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Tasks
{
    public class IsLoginElementPresent
    {
        public static bool ErrorMessage(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver, LoginUI.ErrorMessage);
        }
    }
}
