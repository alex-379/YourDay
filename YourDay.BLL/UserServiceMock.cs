using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL
{
    public class UserServiceMock : IUserService
    {
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
    }
}
