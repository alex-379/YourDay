using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel AddUser(UserRegistrationInputModel user);

        public List<UserOutputModel> GetAllUsers();

        public UserOutputModel GetUserById(int id);
    }
}
