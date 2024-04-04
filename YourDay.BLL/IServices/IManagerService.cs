using YourDay.BLL.Enums;
using YourDay.BLL.Models.CompanyModels.OutputModels;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IManagerService
    {
        public Task<IEnumerable<ManagerNameAndPhoneOutputModel>> GetAllManagers();

        public Task<OrderOutputModel> AddManagerIdToOrder(int managerId, int orderId);

        public Task<OrderOutputModel> AddTaskManager(TaskInputModel task, int orderId);

        public Task<TaskOutputModelAllInfo> AddWorkerForTask(int taskId, int workerId);

        public Task<ApplicationOutputModel> AddApplication(ApplicationInputModel application, string userMail);

        public Task<IEnumerable<CompanyStatisticOutputModel>> GetAllTaskOfOrderOfTheirManager();

        public Task<IEnumerable<UserSpecializationOutputModel>> GetAllWorkers(RoleUI role, TaskOutputModelAllInfo task);

    }
}