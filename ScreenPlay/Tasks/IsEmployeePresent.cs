using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Tasks
{
    public class IsEmployeePresent
    {
        public static bool Form(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver,EmployeeUI.Form);
        }
    }
}
