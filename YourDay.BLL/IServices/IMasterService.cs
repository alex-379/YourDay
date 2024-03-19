using YourDay.BLL.Models.TaskModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IMasterService
    {
        public List<TaskOutputModel> GetAllTask();

        public TaskOutputModel GetTaskById(int id);

        public void UpdateStatusTaskById(int id,TaskOutputModel model);

        public TaskOutputModel AddTask();

        public void RemoveTask(int id);

    }
}