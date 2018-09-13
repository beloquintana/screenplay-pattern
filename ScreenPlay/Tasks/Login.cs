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
    public class Login
    {
        public static void As(IWebDriver driver, string user, string passWord)
        {
            Enter.Text(driver, LoginUI.UserInput, user);
            Enter.Text(driver, LoginUI.PassWordInput, passWord);
            Click.On(driver, LoginUI.LoginButton);
        }
    }
}
