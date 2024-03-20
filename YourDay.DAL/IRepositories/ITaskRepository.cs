using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
       
        public List<TaskDto> GetTaskByOrderId(int Id);
        public IEnumerable<TaskDto> GetTaskByMasterId(int id);
        public void UpdateTaskStatus(TaskStatusDto taskStatus);
        public List<TaskDto> GetAllTasks();
    }
}
