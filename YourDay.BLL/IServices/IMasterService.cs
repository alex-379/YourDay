using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.IServices
{
    public interface IMasterService
    {
        public List<TaskOutputModel> GetAllTask();

        public TaskOutputModel GetTaskByMasterId(int id);

        public void UpdateTasksStatusByTaskId(UpdateTaskStatusInputModel model);

        public void RemoveTask(int id);

    }
}