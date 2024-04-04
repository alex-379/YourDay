using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Test.IRepositories
{
    public interface IUserRepositoryTest
    {
        public UserDto GetUserById(int userId);

        public UserDto GetUserByMail(string userMail);

        public UserDto UpdateUser(UserDto user);

        public IEnumerable<UserDto> GetAllUsers();
    }
}