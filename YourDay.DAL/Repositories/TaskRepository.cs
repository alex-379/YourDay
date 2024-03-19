using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository:ITaskRepository
    {
            Context context = SingletoneStorage.GetStorage().Сontext;
        
        public List<TaskDto> GetTaskByOrderId(int Id)
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            List<TaskDto> tasks = context.Tasks.Where(m => m.OrderId == Id).ToList();
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
