using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserOutputModel RegisterClient(UserRegistrationInputModel client);

        public UserOutputModel AddClientForManager(UserAddForManagerInputModel client);

        public UserOutputModel AddWorkerForManager(UserAddForManagerInputModel client);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public IEnumerable<UserMailOutputModel> GetAllMailBoxes();

        public IEnumerable<UserAuthorizationOutputModel> GetAllMailBoxesWithPasswords();

        public UserOutputModel GetUserById(int id);
    }
}