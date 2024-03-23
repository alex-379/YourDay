using Microsoft.EntityFrameworkCore;
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

        public void AddWorker(UserDto worker)
        {
            if (worker.Role == Role.Worker)
            {
                context.Users.Add(worker);
            }
            context.SaveChanges();
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = context.Users.ToList();
            return users;
        }

        public UserDto GetUserById(int id)
        {
            var user = context.Users.Where(u => u.Id == id).Single();
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

        public void DeleteWorkerById(int id)
        {
            UserDto user = context.Users.Where(c => c.Id == id).Single();
            if (user.Role == Role.Worker)
            {
                user.IsDeleted = true;
                context.Users.Update(user);
            }
            context.SaveChanges();
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