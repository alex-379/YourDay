using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public TaskDto AddTask(TaskDto task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();

            return task;
        }

        public IEnumerable<TaskDto> GetAllTasks()
        {
            var tasks = context.Tasks;

            return tasks;
        }

        public TaskDto GetTaskById(int id)
        {
            TaskDto tasks = context.Tasks.Single(t => t.Id == id);

            return tasks;
        }

        public IEnumerable<TaskDto> GetTasksByOrderId(int orderId)
        {
            var tasks = context.Tasks.Where(t => t.Order.Id == orderId);

            return tasks;
        }

        public IEnumerable<TaskDto> GetTasksByWorkerId(int workerId)
        {
            var tasks = context.Tasks.Include(t => t.Workers.Where(u => u.Role == Role.Worker && u.Id == workerId));

            return tasks;
        }

        public TaskDto UpdateTask(TaskDto task)
        {
            context.Tasks.Update(task);
            context.SaveChanges();

            return task;
        }

        public IEnumerable<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            var filterdTasks = context.Tasks.Where(task =>
                (startDate != null ? task.TimeStart >= startDate : true)
                && (endDate != null ? task.TimeStart <= endDate : true)
                && (status != null ? task.Status == status : true));

            return filterdTasks;
        }
    }
}
