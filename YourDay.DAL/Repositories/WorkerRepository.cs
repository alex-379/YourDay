using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public List<UserDto> GetAllWorkers(Role Worker)
        {
            List<UserDto> users = context.Users.Where(Worker => Worker.Role == Role.Worker).ToList();

            return users;
        }

        public List<UserDto> GetWorkerById(int id)
        {

            List<UserDto> users = context.Users.Where(Worker => Worker.Id == id).ToList();

            return users;
        }

        public List<TaskDto> GetTaskByWorkerId(int id)
        {
            List<TaskDto> tasks = context.Tasks.Include(t => t.Workers.Where(u => u.Role == Role.Worker)).ToList();

            return tasks;
        }
    }
}