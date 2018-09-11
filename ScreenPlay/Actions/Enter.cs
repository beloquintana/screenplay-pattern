using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Actions
{
    public class Enter
    {
        public static void Text(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
    }
}
