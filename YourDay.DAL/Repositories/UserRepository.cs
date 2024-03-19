using Microsoft.Data.SqlClient;
using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        Context context = SingletoneStorage.GetStorage().Сontext;

        public int? AddUser(TaskDto user)
        {
            Console.WriteLine(this);
            context.Users.Update(user);
            context.SaveChanges();
            return user.Id;
            user.Status = 0;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
