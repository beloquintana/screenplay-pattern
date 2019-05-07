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
    //Variante 2 de aplicar single responsibility estrictamente
    public class IsEmployeeSuccessMessagePresent
    {
        public static bool Do(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver, EmployeeUI.SuccessMessage);
        }
    }
}
