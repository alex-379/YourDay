using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.IServices
{
    public interface IMasterService
    {
        public List<MasterOutputModel> GetAllMasters();

        //public List<TaskMasterOutputModel> GetTaskByMasterId(int id);

        public List<MasterOutputModel> GetUserByMasterId(int id);
    }
}