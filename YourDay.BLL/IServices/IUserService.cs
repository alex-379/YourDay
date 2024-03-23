using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel AddUser(UserRegistrationInputModel user);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public IEnumerable<UserOutputModel> GetAllUsersByRole(Role role);

        public IEnumerable<UserSpecializationOutputModel> GetAllUsersSpecializationByRole(Role role);

        public UserOutputModel GetUserById(int id);
    }
}
