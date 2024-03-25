using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class ManagerRepository:IManagerRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public List<UserDto> GetAllManagers(Role Manager)
        {
            List<UserDto> users = context.Users.Where(Manager=>Manager.Role==Role.Manager).ToList();
            return users;
        }
    }
}
