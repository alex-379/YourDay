using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public UserDto AddUser(UserDto person);

        public List<UserDto> GetAllUsers();

        public UserDto GetUserById(int id);

        public UserDto UpdateUser(UserDto user);

        public UserDto DeleteUser(UserDto user);

        public List<UserDto> GetAllUsersByRole(Role role);
    }
}