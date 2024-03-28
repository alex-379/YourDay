using YourDay.BLL.Models.ManagerModels.OutputModel;

namespace YourDay.BLL.IServices
{
    public interface IManagerService
    {
        public List<ManagerNameAndPhoneOutputModel> GetAllManagers();
    }
}