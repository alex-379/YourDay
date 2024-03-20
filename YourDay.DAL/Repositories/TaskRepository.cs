using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        Context context = SingletoneStorage.GetStorage().Сontext;

        public List<TaskDto> GetTaskByOrderId(int Id)
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            List<TaskDto> tasks = context.Tasks.Where(m => m.OrderId == Id).ToList();
            return tasks;
        }

        public IEnumerable<TaskDto> GetTaskByMasterId(int id)
        {
            var tasks = context.Tasks
                .Include(t => t.Workers.Where(u => u.Role == Role.Worker && u.Id == id))
                .ToList();
            return tasks;
        }

        public void UpdateTaskStatus(TaskStatusDto taskStatus)
        {
            Context context = SingletoneStorage.GetStorage().Сontext;

            TaskDto task = context.Tasks.Single(task => task.Id == taskStatus.TaskId);

            if (task != null)
            {
                task.Status = taskStatus.Status;
                context.SaveChanges();
            }
        }

        public void UpdateTaskStatus(TaskDto taskDto)
        {
            throw new NotImplementedException();
        }
    }
}
