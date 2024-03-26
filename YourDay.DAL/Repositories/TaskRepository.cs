using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;
using System.Threading.Tasks;

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

        public IEnumerable<TaskDto> GetAllTasksWithOrderWithSpecialization()
        {
            var tasks = context.Tasks.Include(t=>t.Order).Include(t=>t.Specialization);

            return tasks;
        }

        public IEnumerable<TaskDto> GetAllTasksWithAll()
        {
            var tasks = context.Tasks.Include(t => t.Order).Include(t => t.Specialization).Include(t => t.Workers);

            return tasks;
        }

        public TaskDto GetTaskByIdWithAll(int taskId)
        {
            TaskDto task = context.Tasks
                .Include(t => t.Order)
                .Include(t => t.Specialization)
                .Include(t => t.Workers).Where(t => t.Id == taskId).Single();

            return task;
        }

        public IEnumerable<TaskDto> GetTasksByOrderIdWithSpecialization(int orderId)
        {
            var tasks = context.Tasks.Include(t => t.Specialization).Where(t => t.Order.Id == orderId);

            return tasks;
        }

        public IEnumerable<TaskDto> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId)
        {
            var tasks = context.Tasks
                .Include(t => t.Order)
                .Include(t => t.Specialization)
                .Include(t => t.Workers).Where(t => t.Workers.Any(u => u.Id == 9));

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
