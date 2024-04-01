using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;
        public OrderRepository orderRepository = new OrderRepository();
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

        public List<TaskDto> GetAllTasks()
        {
            List<TaskDto> tasks = context.Tasks.ToList();

            return tasks;
        }

        public TaskDto GetTaskById(int Id)
        {
            TaskDto tasks = context.Tasks.Single(task => task.Id == Id);

            return tasks;
        }

        public List<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate)
        {
            return context.Tasks.Where(task =>
                (startDate != null ? task.TimeStart >= startDate : true)
                && (endDate != null ? task.TimeStart <= endDate : true)
            ).ToList();
        }

        //public void AddTaskManager(TaskDto task, int orderId, int taskId)
        //{
        //    context.Tasks.Add(task);
        //    task.Order = orderRepository.GetOrderById(orderId);
        //    task.Specialization = GetSpecializationById(taskId);
        //    context.SaveChanges();
        //}

        //public void AddTaskManager(TaskDto task, int orderId)
        //{
        //    context.Tasks.Add(task);
        //    task.Order = orderRepository.GetOrderById(orderId);
        //    context.SaveChanges();
        //}
        public void AddTaskManager(TaskDto task, int orderId)
        {
            context.Tasks.Add(task);
            task.Order = orderRepository.GetOrderById(orderId);
            context.SaveChanges();
        }

        public IEnumerable<TaskDto> GetAllTasksWithAll()
        {
            var tasks = context.Tasks.Include(t => t.Order).Include(t => t.Specialization).Include(t => t.Workers);

            return tasks;
        }
        public IEnumerable<TaskDto> GetTaskByOrderId(int id)
        {
            var tasks = context.Tasks.Where(t => t.Order.Id == id).ToList();

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
            var tasks = context.Tasks.Include(t => t.Specialization)
                .Where(t => t.Order.Id == orderId)
                .Where(t => t.Status != Status.Cancelled);

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

        

        public SpecializationDto GetSpecializationById(int Id)
        {
            SpecializationDto specialization = context.Specializations.Single(specialization => specialization.Id == Id);

            return specialization;
        }

        public List<TaskDto> GetTaskByMasterId(int id)
        {

            var tasks = context.Tasks.Where(t => t.Order.Id == id).ToList();
            return tasks;
        }

        public void UpdateTaskStatus(int taskId, Status newTaskStatus)
        {
            TaskDto task = context.Tasks.Single(task => task.Id == taskId);

            if (task != null)
            {
                task.Status = newTaskStatus;
            }

            context.SaveChanges();
        }
    }
}
