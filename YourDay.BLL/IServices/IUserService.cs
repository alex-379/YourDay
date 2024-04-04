using YourDay.BLL.Enums;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IUserService
    {
        public Task<UserOutputModel> AddUser(UserRegistrationInputModel user);

        public Task<UserOutputModel> AddClientForManager(UserRegistrationForManagerInputModel client);

        public Task<UserOutputModel> AddWorkerForManager(UserRegistrationForManagerInputModel worker);

        public Task<UserOutputModel> AddManager(UserRegistrationForManagerInputModel manager);

        public Task<IEnumerable<UserOutputModel>> GetAllUsers();

        public Task<UserOutputModel> GetUserById(int userId);

        public Task<UserOutputModel> DeleteUser(int userId);

        public Task<IEnumerable<UserOutputModel>> GetAllUsersByRole(RoleUI role);

        public Task<IEnumerable<UserSpecializationOutputModel>> GetAllUsersSpecializationByRole(RoleUI role);

        public Task<bool> ConfirmMail(UserRegistrationInputModel user);

        public Task<bool> ConfirmPassword(UserAutenthicationInputModel user);
    }
}