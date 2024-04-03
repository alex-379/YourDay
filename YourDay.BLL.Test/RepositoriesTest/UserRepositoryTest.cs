using YourDay.BLL.Test.IRepositories;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Test.Repositories
{
    public class UserRepositoryTest : IUserRepositoryTest
    {
        public IEnumerable<UserDto> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserByMail(string userMail)
        {
            throw new NotImplementedException();
        }

        public UserDto UpdateUser(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}