using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
        public List<TaskDto> GetTaskByMasterId(int id);
        public void UpdateTaskStatus(int idTask, Status newTaskStatus);
        public List<TaskDto> GetAllTasks();
        public TaskDto GetTaskById(int Id);
        IEnumerable<TaskDto> GetTaskByOrderId(int Id);
        public List<TaskDto> FilterTasks(DateTime? startDate, DateTime? endDate);
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