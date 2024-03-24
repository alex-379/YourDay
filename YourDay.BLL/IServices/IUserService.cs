using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel RegisterClient(UserRegistrationInputModel client);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public UserOutputModel GetUserById(int id);
    }
}