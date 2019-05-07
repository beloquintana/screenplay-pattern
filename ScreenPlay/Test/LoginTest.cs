using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenPlay.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            Login.As(Driver,"admin","admin123");
            Assert.IsTrue(IsEmployeePresent.Form(Driver));
        }

        [Test]
        public void LoginWithBadCredentials()
        {
            Login.As(Driver, "admin", "admin");
            Assert.IsTrue(IsLoginElementPresent.ErrorMessage(Driver));
        }
    }
}
