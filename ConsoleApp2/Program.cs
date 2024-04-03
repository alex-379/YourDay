using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.BLL.Enums;
using YourDay.BLL.IServices;
using YourDay.BLL.Services;
using YourDay.DAL;


namespace ConsoleApp2
{
    internal class Program
    {
        public  void Main(string[] args)
        {
            //Context context = new();

            //ITaskService t = new TaskService();

            //var users =  context.Users
            //        .AsQueryable()
            //        .Include(c => c.Specializations)
            //        .Where(u => u.Role == YourDay.DAL.Enums.Role.Worker)
            //        .Where(u => u.IsDeleted == false).ToList();
            //Console.WriteLine();

            //var task = await t.GetAllTasksWithAll();

            //UserService _userService = new UserService();
            //var users = _userService.GetAllUsersByRoleAA(RoleUI.Client);
            //int a = 8;
        }
    }
}
