using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public int? AddUser(UserDto person);

        public IEnumerable<UserDto> GetAllUsers();
    }
}
