using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IUserRepository
    {
        public UserDto AddUser(UserDto person);

        public IEnumerable<UserDto> GetAllUsers();

        public UserDto GetUserById(int userId);

        public UserDto UpdateUser(UserDto user);

        public IEnumerable<UserDto> GetAllUsersByRole(Role role);

        //public void AddManagerIdToOrder(int managerId, int orderId);
    }
}