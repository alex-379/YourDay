using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public UserDto SetRoleClient(UserDto user);

        public UserDto SetRoleWorker(UserDto user);

        public UserOutputModel AddUser(UserRegistrationInputModel client);

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client);

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel worker);

        public IEnumerable<UserOutputModel> GetAllUsers();

        public IEnumerable<UserMailOutputModel> GetAllMailBoxes();

        public IEnumerable<UserAuthorizationOutputModel> GetAllMailBoxesWithPasswords();

        public UserOutputModel GetUserById(int id);
    }
}