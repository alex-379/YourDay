using AutoMapper;
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

        public TaskOutputModel AddTask(TaskInputModel task)
        {
            SetStatus(task, Status.Received);
            TaskDto taskDtoInput = _mapper.Map<TaskDto>(task);
            TaskDto taskDtoOutput = _taskRepository.AddTask(taskDtoInput);
            TaskOutputModel taskOutput = _mapper.Map<TaskOutputModel>(taskDtoOutput);

            return taskOutput;
        }

        public TaskOutputModel AddWorkerForTask(int taskId, int workerId)
        {
            TaskOutputModel task = this.GetTaskById(taskId);

            List<UserDto> users = (List<UserDto>)_workerRepository.GetAllWorkers(DAL.Enums.Role.Worker);
            List<WorkerOutputModel> result = _mapper.Map<List<WorkerOutputModel>>(users);

            return result;
        }


                public void UpdateTaskStatusByTaskId(int taskId, Status newTaskStatus)
        {
            TaskOutputModel task = this.GetTaskByIdWithOrderWithSpecialization(taskId);
            TaskInputModel taskUpdate = _mapper.Map<TaskInputModel>(task);
            SetStatus(taskUpdate, newTaskStatus);
            UpdateTask(taskUpdate);
        }



        public IEnumerable<TaskOutputModel> GetAllTasksWithOrderWithSpecialization()
        {
            var taskDtos = _taskRepository.GetAllTasksWithOrderWithSpecialization();
            var tasks = _mapper.Map<IEnumerable<TaskOutputModel>>(taskDtos);

            return tasks;
        }

        public TaskOutputModel GetTaskById(int id)
        {
            TaskDto taskDto = _taskRepository.GetTaskById(id);
            TaskOutputModel task = _mapper.Map<TaskOutputModel>(taskDto);

            return task;
        }

        public TaskOutputModel GetTaskByIdWithOrderWithSpecialization(int id)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithOrderWithSpecialization(id);
            TaskOutputModel task = _mapper.Map<TaskOutputModel>(taskDto);

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
            TaskOutputModel task = this.GetTaskByIdWithOrderWithSpecialization(taskId);
            TaskInputModel taskUpdate = _mapper.Map<TaskInputModel>(task);
            SetStatus(taskUpdate, newTaskStatus);
            UpdateTask(taskUpdate);
        }

        public IEnumerable<TaskOutputModel> FilterTasks(DateTime? startDate, DateTime? endDate, Status? status)
        {
            var tasks = _taskRepository.FilterTasks(startDate, endDate, status);
            var result = _mapper.Map<IEnumerable<TaskOutputModel>>(tasks);

            return result;
        }

        private void UpdateTask(TaskInputModel task)
        {
            TaskDto taskDto = _mapper.Map<TaskDto>(task);
            _taskRepository.UpdateTask(taskDto);
        }

        private static void SetStatus(TaskInputModel task, Status status)
        {
            task.Status = status;
        }
    }
}