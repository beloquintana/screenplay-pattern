using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ScreenPlay.Test
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected string Url = "https://testfaceclub.com/ejercicios/";

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
