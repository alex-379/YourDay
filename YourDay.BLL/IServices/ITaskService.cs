using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public List<TaskOutputModel> GetTaskByOrderId(int Id);
        public void UpdateStatusTaskByTaskId(UpdateTaskStatusInputModel taskStatus);
        public void RemoveTask(int id);
        public List<TaskMasterOutputModel> GetAllTask();
    }
}
