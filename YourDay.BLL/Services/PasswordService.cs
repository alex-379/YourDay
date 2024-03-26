using System.Security.Cryptography;
using System.Text;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Services
{
    public class PasswordService
    {
        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        public static string GetRandomPassword()
        {
            Byte[] password = new Byte[(int)Length.PasswordLength];
            string result = Encoding.UTF8.GetString(password);

            return result;
        }

        public static byte[] GetSalt()
        {
            Byte[] salt = new Byte[(int)Length.SaltLength];
            _rng.GetBytes(salt);

            return salt;
        }

        public static byte[] GetHash(string password, byte[] salt)
        {
            byte[] passwordByte = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = passwordByte.Concat(salt).ToArray();
            byte[] hash = SHA256.HashData(saltedPassword);

            return hash;
        }
    }
}