using UserManagementApp.Services;
using Xunit;

namespace UserManagementTests
{
    public class AuthTests
    {
        [Fact]
        public void User_Can_Register_And_Login()
        {
            Authentication auth = new Authentication();

            auth.Register("testuser", "password123", "test@email.com");

            bool result = auth.Authenticate("testuser", "password123");

            Assert.True(result);
        }

        [Fact]
        public void Login_Fails_With_Wrong_Password()
        {
            Authentication auth = new Authentication();

            auth.Register("testuser", "password123", "test@email.com");

            bool result = auth.Authenticate("testuser", "wrongpassword");

            Assert.False(result);
        }

        [Fact]
        public void Login_Fails_For_NonExisting_User()
        {
            Authentication auth = new Authentication();

            bool result = auth.Authenticate("nouser", "password");

            Assert.False(result);
        }
    }
}