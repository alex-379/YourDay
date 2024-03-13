
using YourDay.BLL.IMaster.Models;
using YourDay.BLL.Models.OutputModels;

namespace YourDay.BLL.IMaster
{
    public interface IMasters
    {
        public List<TaskOutputModel> GetAllTask();
        public TaskOutputModel UpdateStatusTask(TaskInputModel model);
        public TaskOutputModel GetTaskById(int id);




    }
}
