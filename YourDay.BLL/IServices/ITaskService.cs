using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public TaskOutputModel AddTask(TaskInputModel task);

        public IEnumerable<TaskOutputModel> GetAllTasks();

        public TaskOutputModel GetTaskById(int id);

        public IEnumerable<TaskInOrderOutputModel> GetTasksByOrderId(int orderId);

        public IEnumerable<TaskInOrderOutputModel> GetTasksByWorkerId(int workerId);

        public void UpdateTaskStatusByTaskId(int taskId, Status newTaskStatus);

        public IEnumerable<TaskOutputModel> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status);
    }
}