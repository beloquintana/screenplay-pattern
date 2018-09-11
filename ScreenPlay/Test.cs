using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenPlay.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver Driver;
        private string Url = "http://verstandqa.com/ejercicios/";

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
        }

        [Test]
        public void SuccessfulLogin()
        {

            //Login.As("");
        }
    }
}
