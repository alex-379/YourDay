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

        public void UpdateTaskStatus(int taskId, Status newTaskStatus)
        {
            TaskDto task = context.Tasks.Single(task => task.Id == taskId); 

            if (task != null)
            {
                task.Status = newTaskStatus;
            }
            
            task.Status = newTaskStatus;
            context.SaveChanges();
        }

        public List<TaskDto> GetAllTasks()
        {
            List<TaskDto> tasks = context.Tasks.ToList();
            return tasks;
        }
        public List<TaskDto> GetTaskById(int Id)
        {
            List<TaskDto> dtos=context.Tasks.Where(task=>task.Id == Id).ToList();
            return dtos;
        }


    }
}
