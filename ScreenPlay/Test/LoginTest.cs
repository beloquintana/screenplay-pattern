using NUnit.Framework;
using ScreenPlay.Tasks;

namespace ScreenPlay.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            Login.As(Driver, "admin", "admin123");
            Assert.IsTrue(IsEmployeePresent.Form(Driver));
        }
    }
}
