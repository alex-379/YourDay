using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

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

        public void AddWorker(UserDto worker)
        {
            context.Users.Add(worker);
            worker.Role= Role.Worker;
            worker.IsDeleted = false;
            context.SaveChanges();
            //worker.Specializations= [taskRepository.GetSpecializationById(specialId)];
        }

        public void AddClient(UserDto worker)
        {
            context.Users.Add(worker);
            worker.Role = Role.Client;
            worker.IsDeleted = false;
            context.SaveChanges();
            //worker.Specializations= [taskRepository.GetSpecializationById(specialId)];
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = context.Users;

            return users;
        }

        public UserDto GetUserById(int userId)
        {
            UserDto user = context.Users.Where(u => u.Id == userId).Single();

            return user;
        }

        public UserDto GetTestUserById(int userId)
        {
            UserDto user = context.Users.Include(u=>u.Specializations).Where(u => u.Id == userId).Single();

            return user;
        }

        public UserDto UpdateUser(UserDto user)
        {
            context.Users.Update(user);
            context.SaveChanges();

            return user;
        }

        public void DeleteByManager(int id)
        {
            UserDto user = context.Users.Where(c => c.Id == id).Single();
            if (user.Role == Role.Worker || user.Role == Role.Client)
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