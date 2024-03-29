using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public void AddClient(UserDto worker);

        public void DeleteByManager(int id);
        public UserDto AddUser(UserDto person);

        public void AddWorker(UserDto person);

        public IEnumerable<UserDto> GetAllUsers();

        public UserDto GetUserById(int userId);

        public UserDto UpdateUser(UserDto user);

        //public UserDto DeleteUser(UserDto user);

        //public void DeleteWorkerById(int id);

        public IEnumerable<UserDto> GetAllUsersByRole(Role role);
    }
}