using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface IManagerService
    {
        public List<ManagerNameAndPhoneOutputModel> GetAllManagers(Role Manager);
    }
}