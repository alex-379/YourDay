using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel AddUser(UserRegistrationInputModel client);

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client);

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel worker);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public UserOutputModel GetUserById(int id);

        public bool ConfirmMail(UserRegistrationInputModel user);

        public bool ConfirmPassword(UserAutenthicationInputModel user);
    }
}