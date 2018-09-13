using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.UI
{
    class LoginUI
    {
        public static By UserInput = By.Id("user");
        public static By PassWordInput = By.Id("pass");
        public static By LoginButton = By.Id("loginButton");
    }
}
