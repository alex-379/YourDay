using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IMasterService
    {
        public List<TaskOutputModel> GetAllTask();

        //public TaskOutputModel UpdateStatusTask(TaskInputModel model);

        public TaskOutputModel GetTaskById(int id);
    }
}