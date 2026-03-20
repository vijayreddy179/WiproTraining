using UserManagementApp.Services;
using Xunit;

namespace UserManagementTests
{
    public class EncryptionTests
    {
        [Fact]
        public void Encrypt_Then_Decrypt_Returns_Original_Value()
        {
            string originalText = "SensitiveData123";

            string encrypted = Encryption.Encrypt(originalText);
            string decrypted = Encryption.Decrypt(encrypted);

            Assert.Equal(originalText, decrypted);
        }

        [Fact]
        public void Encrypted_Data_Is_Not_Same_As_Plain_Text()
        {
            string originalText = "SensitiveData123";

            string encrypted = Encryption.Encrypt(originalText);

            Assert.NotEqual(originalText, encrypted);
        }
    }
}