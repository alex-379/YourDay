using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public UserDto AddUser(UserDto user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = context.Users;

            return users;
        }

        public UserDto GetUserById(int id)
        {
            UserDto user = context.Users.Where(u => u.Id == id).Single();

            return user;
        }

        public UserDto UpdateUser(UserDto user)
        {
            context.Users.Update(user);
            context.SaveChanges();

            return user;
        }
    }
}