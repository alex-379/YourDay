using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
        public List<TaskDto> GetTaskByMasterId(int id);
        public void UpdateTaskStatus(int idTask, Status newTaskStatus);
        public List<TaskDto> GetAllTasks();
        public TaskDto GetTaskById(int Id);
        List<TaskDto> GetTaskByOrderId(int Id);
        public List<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate);
    }
}
