using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UserManagementApp.Models;

namespace UserManagementApp.Services
{
    public class Authentication
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();

        public void Register(string username, string password, string email)
        {
            try
            {
                string hashedPassword = HashPassword(password);
                string encryptedEmail = Encryption.Encrypt(email);

                User user = new User();
                user.Username = username;
                user.HashedPassword = hashedPassword;
                user.EncryptedEmail = encryptedEmail;

                users[username] = user;
                Logging.LogInfo("User registered successfully");
            }
            catch (Exception ex)
            {
                Logging.LogError(ex);
                throw new ApplicationException("Registration failed");
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                if (!users.ContainsKey(username))
                    return false;

                string hashedInput = HashPassword(password);
                return users[username].HashedPassword == hashedInput;
            }
            catch (Exception ex)
            {
                Logging.LogError(ex);
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
