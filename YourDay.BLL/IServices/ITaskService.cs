using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public List<TaskOutputModel> GetTaskByOrderId(int Id);
        public void UpdateStatusTaskByTaskId(int taskId, Status newTaskStatus);
        public void RemoveTask(int id);
        public List<TaskOutputModel> GetAllTask();
        public TaskOutputModel GetTaskById(int Id);
        public List<TaskOutputModel> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
        public List<TaskOutputModel> GetTaskByWorkerId(int MasterId);
    }
}
