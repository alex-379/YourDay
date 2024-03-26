using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
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
            SetDefaultStatus(task, Status.Received);
            TaskDto taskDtoInput = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = _taskRepository.AddTask(taskDtoInput);
            TaskOutputModelWithOrderWithSpecialization taskOutput = _mapper.Map<TaskOutputModelWithOrderWithSpecialization>(taskDtoOutput);

            return taskOutput;
        }

        public TaskOutputModelAllInfo AddWorkerForTask(int taskId, int workerId)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithAll(taskId);
            UserDto userDtoInput = _userRepository.GetUserById(workerId);

            if (taskDto.Workers == null)
            {
                taskDto.Workers = new List<UserDto>() { userDtoInput };
            }
            else
            {
                List<UserDto> Workers = taskDto.Workers.ToList();
                Workers.Add(userDtoInput);
                taskDto.Workers = Workers;
            }

            TaskDto taskDtoOutput = _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        public IEnumerable<TaskOutputModelWithOrderWithSpecialization> GetAllTasksWithOrderWithSpecialization()
        {
            var taskDtos = _taskRepository.GetAllTasksWithOrderWithSpecialization();
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelWithOrderWithSpecialization>>(taskDtos);

            return tasks;
        }

        public IEnumerable<TaskOutputModelAllInfo> GetAllTasksWithAll()
        {
            var taskDtos = _taskRepository.GetAllTasksWithAll();
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelAllInfo>>(taskDtos);

            return tasks;
        }

        public TaskOutputModelAllInfo GetTaskByIdWithAll(int taskId)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithAll(taskId);
            TaskOutputModelAllInfo task = _mapper.Map<TaskOutputModelAllInfo>(taskDto);

            return task;
        }

        public IEnumerable<TaskOutputModelWithSpecialization> GetTasksByOrderIdWithSpecialization(int orderId)
        {
            var taskDtos = _taskRepository.GetTasksByOrderIdWithSpecialization(orderId);
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelWithSpecialization>>(taskDtos);

            return tasks;
        }

        public IEnumerable<TaskOutputModelWithOrderWithSpecialization> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId)
        {
            var taskDtos = _taskRepository.GetTasksByWorkerIdWithOrderWithSpecialization(workerId);
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelWithOrderWithSpecialization>>(taskDtos);

            return tasks;
        }

        public TaskOutputModelAllInfo UpdateTaskStatusByTaskId(int taskId, Status newTaskStatus)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithAll(taskId);
            taskDto.Status = newTaskStatus;
            TaskDto taskDtoOutput = _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        public IEnumerable<TaskOutputModelAllInfo> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            var tasks = _taskRepository.FilterTasks(startDate, endDate, status);
            var result = _mapper.Map<IEnumerable<TaskOutputModelAllInfo>>(tasks);

            return result;
        }

        //public List<TaskOutputModelAllInfo> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        //{
        //    var tasks = _taskRepository.FilterTasks(startDate, endDate, status);
        //    var result = _mapper.Map<IEnumerable<TaskOutputModelAllInfo>>(tasks).ToList();

        //    return result;
        //}

        public TaskOutputModelAllInfo UpdateTask(TaskUpdateInputModelAllInfo task)
        {
            TaskDto taskDto = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        private static void SetDefaultStatus(TaskInputModel task, Status status)
        {
            task.Status = status;
        }
    }
}