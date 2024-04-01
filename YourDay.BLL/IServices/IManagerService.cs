using YourDay.BLL.Models.CompanyModels.OutputModels;
using YourDay.BLL.Models.ManagerModels.OutputModel;

namespace YourDay.BLL.IServices
{
    public interface IManagerService
    {
        public List<ManagerNameAndPhoneOutputModel> GetAllManagers();

        public void AddManagerIdToOrder(int managerId,int orderId);

        public List<CompanyStatisticOutputModel> GetAllTaskOfOrderOfTheirManager();
    }
}