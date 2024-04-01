using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public async Task<UserDto> AddUser(UserDto user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var users = await context.Users.AsQueryable().Where(u => u.IsDeleted != true).ToListAsync();

            return users;
        }

        public async Task<UserDto> GetUserById(int userId)
        {
            UserDto user = await context.Users.AsQueryable().Where(u => u.Id == userId).SingleAsync();

            return user;
        }

        public async Task<UserDto> GetUserByMail(string userMail)
        {
            UserDto user = await context.Users.AsQueryable().Where(u => u.Mail == userMail).SingleAsync();

            return user;
        }

        public async Task<UserDto> UpdateUser(UserDto user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersByRole(Role role)
        {
            var users = await context.Users
                .AsQueryable()
                .Include(c => c.Specializations)
                .Where(u => u.Role == role)
                .Where(u => u.IsDeleted == false).ToListAsync();

            return users;
        }
    }
}