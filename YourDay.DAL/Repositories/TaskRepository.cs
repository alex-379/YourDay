using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;
using System.Collections.Generic;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        Context context = SingletoneStorage.GetStorage().Сontext;
        public OrderRepository orderRepository = new OrderRepository();




        public List<TaskDto> GetTaskByMasterId(int id)
        {

            var tasks = context.Tasks.Where(t => t.Order.Id == id).ToList();
            return tasks;
        }

        public IEnumerable<TaskDto> GetTaskByOrderId(int id)
        {
            var tasks = context.Tasks.Where(t => t.Order.Id == id).ToList();

            return tasks;
        }

        public void UpdateTaskStatus(int taskId, Status newTaskStatus)
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
        

        public IEnumerable<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            var filterdTasks = context.Tasks.Where(task =>
                (startDate != null ? task.TimeStart >= startDate : true)
                && (endDate != null ? task.TimeStart <= endDate : true)
                && (status != null ? task.Status == status : true));

            return filterdTasks;
        }

        public void AddTask(TaskDto task, int orderId)
        {
            context.Tasks.Add(task);
            task.Order= orderRepository.GetOrderById(orderId);
            context.SaveChanges();
        }
    }
}
