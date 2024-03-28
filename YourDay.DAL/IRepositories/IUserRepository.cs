using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {

        public UserDto AddUser(UserDto person);

        public void AddWorker(UserDto person);

        public IEnumerable<UserDto> GetAllUsers();

        public UserDto GetUserById(int id);

        public UserDto UpdateUser(UserDto user);

        public UserDto DeleteUser(UserDto user);

        public void DeleteWorkerById(int id);

        public IEnumerable<UserDto> GetAllUsersByRole(Role role);
    }
}