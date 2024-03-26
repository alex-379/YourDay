using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
        public TaskDto AddTask(TaskDto task);

        public IEnumerable<TaskDto> GetAllTasksWithOrderWithSpecialization();

        public IEnumerable<TaskDto> GetAllTasksWithAll();

        public TaskDto GetTaskByIdWithAll(int taskId);

        public IEnumerable<TaskDto> GetTasksByOrderIdWithSpecialization(int orderId);

        public IEnumerable<TaskDto> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId);

        public TaskDto UpdateTask(TaskDto task);

        public IEnumerable<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
    }
}