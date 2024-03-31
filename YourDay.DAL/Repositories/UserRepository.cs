using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;
        public TaskRepository taskRepository = new TaskRepository();

        public UserDto AddUser(UserDto user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = context.Users.Where(u => u.IsDeleted != true);

            return users;
        }

        public UserDto GetUserById(int userId)
        {
            UserDto user = context.Users.Where(u => u.Id == userId).Single();

            return user;
        }

        public UserDto UpdateUser(UserDto user)
        {
            context.Users.Update(user);
            context.SaveChanges();

            return user;
        }

        public IEnumerable<UserDto> GetAllUsersByRole(Role role)
        {
            var users = context.Users
                .Include(c => c.Specializations)
                .Where(u => u.Role == role)
                .Where(u => u.IsDeleted == false).ToList();
            return users;
        }
    }
}