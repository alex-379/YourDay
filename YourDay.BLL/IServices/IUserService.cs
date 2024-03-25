using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel RegisterClient(UserRegistrationInputModel client);

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client);

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel client);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public IEnumerable<UserMailOutputModel> GetAllMailBoxes();

        public IEnumerable<UserAuthorizationOutputModel> GetAllMailBoxesWithPasswords();

        public UserOutputModel GetUserById(int id);
    }
}