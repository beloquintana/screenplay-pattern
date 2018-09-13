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
    public class EmployeeTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login.As(Driver, "admin", "admin123");
        }

        [Test]
        public void AddEmployeeTest()
        {
            AddEmployee.WithTheData(Driver, "Juan", "juan@gmail.com","MTV","598752022");
            Assert.IsTrue(AcceptAlert.Success(Driver));
        }        
    }
}
