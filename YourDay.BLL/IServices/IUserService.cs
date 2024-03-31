using YourDay.BLL.Enums;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel AddUser(UserRegistrationInputModel client);

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client);

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel worker);

        public UserOutputModel AddManager(UserRegistrationInputModel manager);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public UserOutputModel GetUserById(int userId);

        public void DeleteUser(int userId);

        public IEnumerable<UserOutputModel> GetAllUsersByRole(RoleUI role);

        public IEnumerable<UserSpecializationOutputModel> GetAllUsersSpecializationByRole(RoleUI role);

        public bool ConfirmMail(UserRegistrationInputModel user);

        public bool ConfirmPassword(UserAutenthicationInputModel user);
    }
}