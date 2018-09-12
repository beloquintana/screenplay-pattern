using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Test
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected string Url = "http://verstandqa.com/ejercicios/";

        [SetUp]
        public void SetUpBase()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
        }

        [TearDown]
        public void TearDownBase()
        {
            if (Driver != null)
                Driver.Quit();
        }
    }
}
