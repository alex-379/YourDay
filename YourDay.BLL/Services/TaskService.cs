using AutoMapper;
using System.Threading.Tasks;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Clients
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IUserRepository _userRepository;
        private readonly Mapper _mapper;

        public TaskService()
        {
            _taskRepository = new TaskRepository();
            _userRepository = new UserRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public TaskOutputModelWithOrderWithSpecialization AddTask(TaskInputModel task)
        {
            SetStatus(task, Status.Received);
            TaskDto taskDtoInput = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = _taskRepository.AddTask(taskDtoInput);
            TaskOutputModelWithOrderWithSpecialization taskOutput = _mapper.Map<TaskOutputModelWithOrderWithSpecialization>(taskDtoOutput);

            return taskOutput;
        }

        public TaskOutputModelAllInfo AddWorkerForTask(int taskId, int workerId)
        {
            TaskOutputModelAllInfo task = this.GetTaskByIdWithWorkers(taskId);
            TaskInputModelWorkers taskUpdate = _mapper.Map<TaskInputModelWorkers>(task);
            UserDto worker = _userRepository.GetUserById(workerId);
            taskUpdate.Workers.ToList().Add(worker);
            TaskOutputModelAllInfo taskOutput = this.UpdateTask(taskUpdate);

            return taskOutput;
        }

        public IEnumerable<TaskOutputModel> GetAllTasksWithOrderWithSpecialization()
        {
            var taskDtos = _taskRepository.GetAllTasksWithOrderWithSpecialization();
            var tasks = _mapper.Map<IEnumerable<TaskOutputModel>>(taskDtos);

            return tasks;
        }

        public TaskOutputModel GetTaskById(int taskId)
        {
            TaskDto taskDto = _taskRepository.GetTaskById(taskId);
            TaskOutputModel task = _mapper.Map<TaskOutputModel>(taskDto);

            return task;
        }

        public TaskOutputModel GetTaskByIdWithOrderWithSpecialization(int taskId)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithOrderWithSpecialization(taskId);
            TaskOutputModel task = _mapper.Map<TaskOutputModel>(taskDto);

            return task;
        }

        public TaskOutputModelAllInfo GetTaskByIdWithWorkers(int taskId)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithOrderWithSpecialization(taskId);
            TaskOutputModelAllInfo task = _mapper.Map<TaskOutputModelAllInfo>(taskDto);

            return task;
        }

        public IEnumerable<TaskInOrderOutputModel> GetTasksByOrderIdWithSpecialization(int orderId)
        {
            var taskDtos = _taskRepository.GetTasksByOrderIdWithSpecialization(orderId);
            var tasks = _mapper.Map<IEnumerable<TaskInOrderOutputModel>>(taskDtos);

            return tasks;
        }

        public IEnumerable<TaskInOrderOutputModel> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId)
        {
            var taskDtos = _taskRepository.GetTasksByWorkerIdWithOrderWithSpecialization(workerId);
            var tasks = _mapper.Map<IEnumerable<TaskInOrderOutputModel>>(taskDtos);

            return tasks;
        }

        public void UpdateTaskStatusByTaskId(int taskId, Status newTaskStatus)
        {
            //TaskOutputModel task = this.GetTaskByIdWithOrderWithSpecialization(taskId);
            //TaskInputModel taskUpdate = _mapper.Map<TaskInputModel>(task);
            //SetStatus(taskUpdate, newTaskStatus);
            //UpdateTask(taskUpdate);
        }

        public IEnumerable<TaskOutputModel> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            var tasks = _taskRepository.FilterTasks(startDate, endDate, status);
            var result = _mapper.Map<IEnumerable<TaskOutputModel>>(tasks);

            return result;
        }

        private TaskOutputModelAllInfo UpdateTask(TaskInputModelWorkers task)
        {
            TaskDto taskDto = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        private static void SetStatus(TaskInputModel task, Status status)
        {
            task.Status = status;
        }
    }
}