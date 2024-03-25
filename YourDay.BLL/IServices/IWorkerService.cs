using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IWorkerService
    {
        public List<WorkerOutputModel> GetAllWorkers();

        public List<WorkerOutputModel> GetTaskByWorkerId(int id);

        public List<WorkerOutputModel> GetUserByWorkerId(int id);
    }
}