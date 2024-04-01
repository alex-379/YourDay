using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
        public Task<IEnumerable<TaskDto>> GetAllTasksWithOrderWithSpecialization();

        public Task<IEnumerable<TaskDto>> GetAllTasks();

        public Task<TaskDto> GetTaskById(int taskId);

        public Task<IEnumerable<TaskDto>> FilterTasks(DateTime? startDate, DateTime? endDate);

        public Task<IEnumerable<TaskDto>> GetAllTasksWithAll();

        public Task<IEnumerable<TaskDto>> GetTaskByOrderId(int orderId);

        public Task<TaskDto> GetTaskByIdWithAll(int taskId);

        public Task<IEnumerable<TaskDto>> GetTasksByOrderIdWithSpecialization(int orderId);

        public Task<IEnumerable<TaskDto>> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId);

        public Task<TaskDto> UpdateTask(TaskDto task);

        public Task<IEnumerable<TaskDto>> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
    }
}