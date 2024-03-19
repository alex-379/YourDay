using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public UserDto AddUser(UserDto person);

        public IEnumerable<UserDto> GetAllUsers();
    }
}
