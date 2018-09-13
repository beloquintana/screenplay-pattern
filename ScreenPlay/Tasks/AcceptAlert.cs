using OpenQA.Selenium;
using ScreenPlay.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
