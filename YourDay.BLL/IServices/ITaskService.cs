using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public TaskOutputModelWithOrderWithSpecialization AddTask(TaskInputModel task);

        public TaskOutputModelAllInfo AddWorkerForTask(int taskId, int workerId);

        public IEnumerable<TaskOutputModel> GetAllTasksWithOrderWithSpecialization();

        public TaskOutputModel GetTaskById(int taskId);

        public TaskOutputModel GetTaskByIdWithOrderWithSpecialization(int taskId);

        public IEnumerable<TaskInOrderOutputModel> GetTasksByOrderIdWithSpecialization(int orderId);

        public IEnumerable<TaskInOrderOutputModel> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId);

        public void UpdateTaskStatusByTaskId(int taskId, Status newTaskStatus);

        public IEnumerable<TaskOutputModel> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
    }
}