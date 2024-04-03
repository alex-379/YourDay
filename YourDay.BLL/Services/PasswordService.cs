using System.Security.Cryptography;
using System.Text;
using YourDay.BLL.IServices;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        public string GetRandomPassword()
        {
            byte[] passwordByte = new byte[(int)Length.PasswordLength];
            _rng.GetBytes(passwordByte);
            string password = Convert.ToBase64String(passwordByte);

            return password;
        }

        public byte[] GetSalt()
        {
            byte[] salt = new byte[(int)Length.SaltLength];
            _rng.GetBytes(salt);

            return salt;
        }

        public byte[] GetHash(string password, byte[] salt)
        {
            byte[] passwordByte = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = passwordByte.Concat(salt).ToArray();
            byte[] hash = SHA256.HashData(saltedPassword);

            return hash;
        }
    }
}