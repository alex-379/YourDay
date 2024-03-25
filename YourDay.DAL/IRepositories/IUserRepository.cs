using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public UserDto AddUser(UserDto person);

        public List<UserDto> GetAllUsers();

        public UserDto GetUserById(int id);

        public UserDto UpdateUser(UserDto user);
    }
}