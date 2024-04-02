namespace YourDay.BLL.IServices
{
    public interface IPasswordService
    {
        public string GetRandomPassword();

        public byte[] GetSalt();

        public byte[] GetHash(string password, byte[] salt);
    }
}
