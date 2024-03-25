using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
        public TaskDto AddTask(TaskDto task);

        public IEnumerable<TaskDto> GetAllTasks();

        public TaskDto GetTaskById(int Id);

        public IEnumerable<TaskDto> GetTasksByOrderId(int orderId);

        public IEnumerable<TaskDto> GetTasksByWorkerId(int workerId);

        public TaskDto UpdateTask(TaskDto task);

        public IEnumerable<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
    }
}