using YourDay.BLL.Enums;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public TaskOutputModelWithOrderWithSpecialization AddTask(TaskInputModel task);

        public TaskOutputModelAllInfo AddWorkerForTask(int taskId, int workerId);

        public IEnumerable<TaskOutputModelWithOrderWithSpecialization> GetAllTasksWithOrderWithSpecialization();

        public IEnumerable<TaskOutputModelAllInfo> GetAllTasksWithAll();

        public TaskOutputModelAllInfo GetTaskByIdWithAll(int taskId);

        public IEnumerable<TaskOutputModelWithSpecialization> GetTasksByOrderIdWithSpecialization(int orderId);

        public IEnumerable<TaskOutputModelWithOrderWithSpecialization> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId);

        public TaskOutputModelAllInfo UpdateTaskStatusByTaskId(int taskId, StatusUI newTaskStatus);

        public IEnumerable<TaskOutputModelAllInfo> FilterTasks(DateTime? startDate, DateTime? endDate, StatusUI? status);

        public TaskOutputModelAllInfo UpdateTask(TaskUpdateInputModelAllInfo task);
    }
}