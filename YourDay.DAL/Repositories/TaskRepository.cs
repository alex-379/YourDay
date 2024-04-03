using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public async Task<TaskDto> AddTask(TaskDto task)
        {
            using (Context context = new Context())
            {
                context.Tasks.Add(task);
                await context.SaveChangesAsync();

                return task;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasksWithOrderWithSpecialization()
        {
            using (Context context = new Context())
            {
                var tasks = await context.Tasks.AsQueryable().Include(t => t.Order).Include(t => t.Specialization).ToListAsync();

                return tasks;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasks()
        {
            using (Context context = new Context())
            {
                var tasks = await context.Tasks.AsQueryable().ToListAsync();

                return tasks;
            }
        }

        public async Task<TaskDto> GetTaskById(int taskId)
        {
            using (Context context = new Context())
            {
                TaskDto tasks = await context.Tasks.AsQueryable().Where(t => t.Id == taskId).SingleAsync();

                return tasks;
            }
        }

        public async Task<IEnumerable<TaskDto>> FilterTasks(DateTime? startDate, DateTime? endDate)
        {
            using (Context context = new Context())
            {
                var filteredTasks = await context.Tasks.AsQueryable().Where(task =>
                   (startDate != null ? task.TimeStart >= startDate : true)
                   && (endDate != null ? task.TimeStart <= endDate : true)
               ).ToListAsync();

                return filteredTasks;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetAllTasksWithAll()
        {
            using (Context context = new Context())
            {
                var tasks = await context.Tasks.AsQueryable().Include(t => t.Order).Include(t => t.Specialization).Include(t => t.Workers).ToListAsync();

                return tasks;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetTaskByOrderId(int orderId)
        {
            using (Context context = new Context())
            {
                var tasks = await context.Tasks.AsQueryable().Where(t => t.Order.Id == orderId).ToListAsync();

                return tasks;
            }
        }

        public async Task<TaskDto> GetTaskByIdWithAll(int taskId)
        {
            using (Context context = new Context())
            {
                TaskDto task = await context.Tasks
                    .AsQueryable()
                    .Include(t => t.Order)
                    .Include(t => t.Specialization)
                    .Include(t => t.Workers).Where(t => t.Id == taskId).SingleAsync();
                return task;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetTasksByOrderIdWithSpecialization(int orderId)
        {
            using (Context context = new Context())
            {
                var tasks = await context.Tasks.AsQueryable()
                    .Include(t => t.Specialization)
                    .Where(t => t.Order.Id == orderId)
                    .Where(t => t.Status != Status.Cancelled).ToListAsync();

                return tasks;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId)
        {
            using (Context context = new Context())
            {
                var tasks = await context.Tasks
                    .AsQueryable()
                    .Include(t => t.Order)
                    .Include(t => t.Specialization)
                    .Include(t => t.Workers).Where(t => t.Workers.Any(u => u.Id == workerId)).ToListAsync();

                return tasks;
            }
        }

        public async Task<TaskDto> UpdateTask(TaskDto task)
        {
            using (Context context = new Context())
            {
                context.Tasks.Update(task);
                await context.SaveChangesAsync();

                return task;
            }
        }

        public async Task<IEnumerable<TaskDto>> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            using (Context context = new Context())
            {
                var filterdTasks = await context.Tasks.AsQueryable().Where(task =>
                    (startDate != null ? task.TimeStart >= startDate : true)
                    && (endDate != null ? task.TimeStart <= endDate : true)
                    && (status != null ? task.Status == status : true)).ToListAsync();

                return filterdTasks;
            }
        }

        public async Task<IEnumerable<TaskDto>> GetAllTaskOfOrderOfTheirManager()
        {
            using (Context context = new Context())
            {
                var tasksWithOrdersAndManagers = await context.Tasks
                    .AsQueryable()
                    .Include(task => task.Order)
                    .ThenInclude(task => task.Manager)
                    .ThenInclude(task=>task.Orders)
                    .ToListAsync();

                return tasksWithOrdersAndManagers;
            }
        }
    }
}