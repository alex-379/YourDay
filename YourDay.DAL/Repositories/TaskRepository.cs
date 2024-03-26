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
            TaskDto task = context.Tasks.Single(task => task.Id == taskId); 

            if (task != null)
            {
                task.Status = newTaskStatus;
            }
            
            context.SaveChanges();
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
        

        public List<TaskDto> FilterTasks(DateTime? startDate,DateTime? endDate)
        {
            return context.Tasks.Where(task =>
                (startDate != null ? task.TimeStart >= startDate : true)
                && (endDate  != null ? task.TimeStart <= endDate : true)
            ).ToList();
        }

        public void AddTask(TaskDto task, int orderId)
        {
            context.Tasks.Add(task);
            task.Order= orderRepository.GetOrderById(orderId);
            context.SaveChanges();
        }
    }
}
