using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class UserRepository:IUserRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public UserDto AddUser(UserDto user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }

        public List<UserDto> GetAllUsers()
        {
            List<UserDto> users = context.Users.ToList();

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

        public UserDto DeleteUser(UserDto user)
        {
            user.IsDeleted = true;
            context.Users.Update(user);
            context.SaveChanges();

            return user;
        }

        public List<UserDto> GetAllUsersByRole(Role role)
        {
            var users = context.Users.Where(u => u.Role == role);

            return users;
        }
    }
}