using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        Context context = SingletoneStorage.GetStorage().Сontext;
        
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
        public List<TaskDto> GetTaskByOrderId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<TaskDto> FilterTasks(DateTime? startDate)
        {
            return context.Tasks.Where(task => task.TimeStart >= startDate).ToList();
        }
    }
}
