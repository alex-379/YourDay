using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.IServices
{
    public interface IMasterService
    {
        public List<TaskDto> GetAllTask();

        public TaskOutputModel GetTaskByMasterId(int id);

        public void UpdateTasksStatusByTaskId(UpdateTaskStatusOutputModel model);

        public TaskOutputModel AddTask();

        public void RemoveTask(int id);

    }
}