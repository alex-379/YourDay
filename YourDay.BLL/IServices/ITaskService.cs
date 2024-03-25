using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public TaskOutputModel AddTask(TaskInputModel task);

        public IEnumerable<TaskOutputModel> GetAllTasksWithOrderWithSpecialization();

        public TaskOutputModel GetTaskById(int id);

        public TaskOutputModel GetTaskByIdWithOrderWithSpecialization(int id);

        public IEnumerable<TaskInOrderOutputModel> GetTasksByOrderIdWithSpecialization(int orderId);

        public IEnumerable<TaskInOrderOutputModel> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId);

        public void UpdateTaskStatusByTaskId(int taskId, Status newTaskStatus);

        public IEnumerable<TaskOutputModel> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
    }
}