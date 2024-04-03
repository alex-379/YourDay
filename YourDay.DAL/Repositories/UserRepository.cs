using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<UserDto> AddUser(UserDto user)
        {
            using (Context context = new Context())
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();

                return user;
            }
        }
        
        
        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            using (Context context = new Context())
            {
                var users = await context.Users.AsQueryable().Where(u => u.IsDeleted != true).ToListAsync();

                return users;
            }
        }

        public async Task<UserDto> GetUserById(int userId)
        {
            using (Context context = new Context())
            {
                UserDto user = await context.Users.AsQueryable().Where(u => u.Id == userId).SingleAsync();

                return user;
            }
        }

        public async Task<UserDto> GetUserByMail(string userMail)
        {
            using (Context context = new Context())
            {
                UserDto user = await context.Users.AsQueryable().Where(u => u.Mail == userMail).SingleAsync();

                return user;
            }
        }

        public async Task<UserDto> UpdateUser(UserDto user)
        {
            using (Context context = new Context())
            {
                context.Users.Update(user);
                await context.SaveChangesAsync();

                return user;
            }
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersByRole(Role role)
        {
            using (Context context = new Context())
            {
                var users = await context.Users
                    .AsQueryable()
                    .Include(c => c.Specializations)
                    .Where(u => u.Role == role)
                    .Where(u => u.IsDeleted == false).ToListAsync();

                return users;
            }
        }

        public List<UserDto> GetAllUsersByRoleForTask(Role role)
        {
            Context context = new Context();
            var users = context.Users
                    .AsQueryable()
                    .Include(c => c.Specializations)
                    .Where(u => u.Role == role)
                    .Where(u => u.IsDeleted == false).ToList();

                return users;
            
        }

        public void SetWorkerForTask(int workerId, int taskId)
        {
            Context context = new Context();
            UserDto user = context.Users.Where(c => c.Id == workerId).Single();
            if (user.WorkerTasks != null)
            {
                user.WorkerTasks.Append(context.Tasks.Where(c => c.Id == taskId).Single());
            }
        }
    }
}