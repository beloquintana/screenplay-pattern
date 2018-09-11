using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Actions
{
    class Click
    {
        public static void On(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
