using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL;
using YourDay.DAL.Repositories;
using YourDay.BLL.Services;
using YourDay.BLL.Models.TaskModels.InputModels;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Context context = new();

            UserRepository userrep = new UserRepository();
            TaskService t = new TaskService();
            

            var tasks = await t.GetTaskById(22);


            ManagerService m = new ManagerService();
            //var a = await m.GetAllWorkersForTask(task);
            //var task = context.Tasks
            //        .AsQueryable()
            //        .Include(c => c.Specialization)
            //        .Where(u => u.Id == 22).Single();


            //var users = context.Users
            //        .AsQueryable()
            //        .Include(c => c.Specializations)
            //        .Include(c => c.WorkerTasks)
            //        .Where(u => u.Role == YourDay.DAL.Enums.Role.Worker)
            //        .Where(u => u.IsDeleted == false)
            //        .Where(u => u.Specializations.Any(s => s.Id == task.Specialization.Id))
            //        .Where(u => u.WorkerTasks.Any(s => s.TimeStart.Date != task.TimeStart.Date)).ToList();




            Console.WriteLine();
        }
    }
}
