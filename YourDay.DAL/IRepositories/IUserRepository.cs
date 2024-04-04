using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public Task<UserDto> AddUser(UserDto user);

        public Task<IEnumerable<UserDto>> GetAllUsers();

        public Task<UserDto> GetUserById(int userId);

        public Task<UserDto> GetUserByMail(string userMail);

        public Task<UserDto> UpdateUser(UserDto user);

        public Task<IEnumerable<UserDto>> GetAllUsersByRole(Role role);

        public Task<IEnumerable<UserDto>> GetAllUsersByRoleBySpecialization(Role role, int specializationId);

        public Task<IEnumerable<UserDto>> GetAllWorkersForTask(TaskDto task);
    }
}