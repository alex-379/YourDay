using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel AddUser(UserRegistrationInputModel client);

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client);

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel worker);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public UserOutputModel GetUserById(int userId);

        public IEnumerable<UserOutputModel> GetAllUsersByRole(Role role);

        public bool ConfirmMail(UserRegistrationInputModel user);

        public bool ConfirmPassword(UserAutenthicationInputModel user);
    }
}