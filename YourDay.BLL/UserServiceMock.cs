using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL
{
    public class UserServiceMock : IUserService
    {
        private List<UserOutputModel> _users = new();

        public UserServiceMock()
        {
            _users = new List<UserOutputModel>()
        {
                new UserOutputModel { Id = 0, UserName = "Тест Тестович", Mail = "test@mail.ru", Phone = "+783464" },
                new UserOutputModel { Id = 1, UserName = "Иван Иванович", Mail = "ivan@mail.ru", Phone = "+75424" },
                new UserOutputModel { Id = 2, UserName = "Петр Петрович", Mail = "petr@mail.ru", Phone = "+785787" }
        };
        }
        public UserOutputModel AddUser(UserRegistrationInputModel user)
        {
            return new UserOutputModel
            {
                Id = 0,
                UserName = user.UserName,
                Mail = user.Mail,
                Phone = user.Phone
            };
        }

        public List<UserOutputModel> GetAllUsers()
        {
            return _users;
        }

        public UserOutputModel GetUserById(int id)
        {
            return _users[id];
        }
    }
}
