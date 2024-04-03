using AutoMapper;
using YourDay.BLL.Enums;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly Mapper _mapper;

        public TaskService()
        {
            _taskRepository = new TaskRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public async Task<TaskOutputModelWithOrderWithSpecialization> AddTask(TaskInputModel task)
        {
            SetDefaultStatus(task, Status.Received);
            TaskDto taskDtoInput = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = await _taskRepository.AddTask(taskDtoInput);
            TaskOutputModelWithOrderWithSpecialization taskOutput = _mapper.Map<TaskOutputModelWithOrderWithSpecialization>(taskDtoOutput);

            return taskOutput;
        }

        public async Task<IEnumerable<TaskOutputModelWithOrderWithSpecialization>> GetAllTasksWithOrderWithSpecialization()
        {
            var taskDtos = await _taskRepository.GetAllTasksWithOrderWithSpecialization();
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelWithOrderWithSpecialization>>(taskDtos);

            return tasks;
        }

        public async Task<IEnumerable<TaskOutputModelAllInfo>> GetAllTasksWithAll()
        {
            var taskDtos = await _taskRepository.GetAllTasksWithAll();
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelAllInfo>>(taskDtos);

            return tasks;
        }

        public async Task<TaskOutputModelAllInfo> GetTaskByIdWithAll(int taskId)
        {
            TaskDto taskDto = await _taskRepository.GetTaskByIdWithAll(taskId);
            TaskOutputModelAllInfo task = _mapper.Map<TaskOutputModelAllInfo>(taskDto);

            return task;
        }

        public async Task<IEnumerable<TaskOutputModelWithSpecialization>> GetTasksByOrderIdWithSpecialization(int orderId)
        {
            var taskDtos = await _taskRepository.GetTasksByOrderIdWithSpecialization(orderId);
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelWithSpecialization>>(taskDtos);

            return tasks;
        }

        public async Task<IEnumerable<TaskOutputModelWithOrderWithSpecialization>> GetTasksByWorkerIdWithOrderWithSpecialization(int workerId)
        {
            var taskDtos = await _taskRepository.GetTasksByWorkerIdWithOrderWithSpecialization(workerId);
            var tasks = _mapper.Map<IEnumerable<TaskOutputModelWithOrderWithSpecialization>>(taskDtos);

            return tasks;
        }

        public async Task<TaskOutputModelAllInfo> UpdateTaskStatusByTaskId(int taskId, StatusUI newTaskStatus)
        {
            TaskDto taskDto = await _taskRepository.GetTaskByIdWithAll(taskId);
            taskDto.Status = (Status)newTaskStatus;
            TaskDto taskDtoOutput = await _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        public async Task<IEnumerable<TaskOutputModelAllInfo>> FilterTasks(DateTime? startDate, DateTime? endDate, StatusUI? statusUi)
        {
            Status? status = (statusUi != null) ? (Status)statusUi : null;
            var tasks = await _taskRepository.FilterTasks(startDate, endDate, status);
            var result = _mapper.Map<IEnumerable<TaskOutputModelAllInfo>>(tasks);

            return result;
        }

        public async Task<TaskOutputModelAllInfo> UpdateTask(TaskUpdateInputModelAllInfo task)
        {
            TaskDto taskDto = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = await _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }


        public async Task<TaskOutputModelAllInfo> SetWorkerTask(TaskOutputModelAllInfo task)
        {
            TaskDto taskDto = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = await _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }


        private static void SetDefaultStatus(TaskInputModel task, Status status)
        {
            task.Status = (StatusUI)status;
        }
    }
}