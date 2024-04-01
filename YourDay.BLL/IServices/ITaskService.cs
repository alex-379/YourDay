using YourDay.BLL.Enums;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface ITaskService
    {
        public Task<TaskOutputModelWithOrderWithSpecialization> AddTask(TaskInputModel task);

        public Task<IEnumerable<TaskOutputModelWithOrderWithSpecialization>> GetAllTasksWithOrderWithSpecialization();

        public Task<IEnumerable<TaskOutputModelAllInfo>> GetAllTasksWithAll();

        public Task<TaskOutputModelAllInfo> GetTaskByIdWithAll(int taskId);

        public Task<IEnumerable<TaskOutputModelWithSpecialization>> GetTasksByOrderIdWithSpecialization(int orderId);

        public Task<IEnumerable<TaskOutputModelWithOrderWithSpecialization>> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId);

        public Task<TaskOutputModelAllInfo> UpdateTaskStatusByTaskId(int taskId, StatusUI newTaskStatus);

        public Task<IEnumerable<TaskOutputModelAllInfo>> FilterTasks(DateTime? startDate, DateTime? endDate, StatusUI? statusUi);

        public Task<TaskOutputModelAllInfo> UpdateTask(TaskUpdateInputModelAllInfo task);
    }
}