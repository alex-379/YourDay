using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public OrderRepository orderRepository = new OrderRepository();

        public async Task<TaskDto> AddTask(TaskDto task)
        {
            context.Tasks.Add(task);
            await context.SaveChangesAsync();

            return task;
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasksWithOrderWithSpecialization()
        {
            var tasks = await context.Tasks.AsQueryable().Include(t => t.Order).Include(t => t.Specialization).ToListAsync();

            return tasks;
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasks()
        {
            var tasks = await context.Tasks.AsQueryable().ToListAsync();

            return tasks;
        }

        public async Task<TaskDto> GetTaskById(int taskId)
        {
            TaskDto tasks = await context.Tasks.AsQueryable().Where(t => t.Id == taskId).SingleAsync();

            return tasks;
        }

        public async Task<IEnumerable<TaskDto>> FilterTasks(DateTime? startDate, DateTime? endDate)
        {
            var filteredTasks = await context.Tasks.AsQueryable().Where(task =>
               (startDate != null ? task.TimeStart >= startDate : true)
               && (endDate != null ? task.TimeStart <= endDate : true)
           ).ToListAsync();

            return filteredTasks;
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasksWithAll()
        {
            var tasks = await context.Tasks.AsQueryable().Include(t => t.Order).Include(t => t.Specialization).Include(t => t.Workers).ToListAsync();

            return tasks;
        }

        public async Task<IEnumerable<TaskDto>> GetTaskByOrderId(int orderId)
        {
            var tasks = await context.Tasks.AsQueryable().Where(t => t.Order.Id == orderId).ToListAsync();

            return tasks;
        }

        public async Task<TaskDto> GetTaskByIdWithAll(int taskId)
        {
            TaskDto task = await context.Tasks
                .AsQueryable()
                .Include(t => t.Order)
                .Include(t => t.Specialization)
                .Include(t => t.Workers).Where(t => t.Id == taskId).SingleAsync();
            return task;
        }

        public async Task<IEnumerable<TaskDto>> GetTasksByOrderIdWithSpecialization(int orderId)
        {
            var tasks = await context.Tasks.Include(t => t.Specialization).Where(t => t.Order.Id == orderId).ToListAsync();

            return tasks;
        }

        public async Task<IEnumerable<TaskDto>> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId)
        {
            var tasks = await context.Tasks
                .AsQueryable()
                .Include(t => t.Order)
                .Include(t => t.Specialization)
                .Include(t => t.Workers).Where(t => t.Workers.Any(u => u.Id == workerId)).ToListAsync();

            return tasks;
        }

        public async Task<TaskDto> UpdateTask(TaskDto task)
        {
            context.Tasks.Update(task);
            await context.SaveChangesAsync();

            return task;
        }

        public async Task<IEnumerable<TaskDto>> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            var filterdTasks = await context.Tasks.AsQueryable().Where(task =>
                (startDate != null ? task.TimeStart >= startDate : true)
                && (endDate != null ? task.TimeStart <= endDate : true)
                && (status != null ? task.Status == status : true)).ToListAsync();

            return filterdTasks;
        }
    }
}