using AutoMapper;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.IServices;
using YourDay.DAL.Enums;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.DAL.IRepositories;

namespace YourDay.BLL.Clients
{
    public class TaskService:ITaskService
    {
        private TaskRepository _taskRepository;
        private Mapper _mapper;

        public TaskService()
        {
            _taskRepository = new TaskRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public List<TaskOutputModel> GetTaskByOrderId(int Id)
        {
            IEnumerable<TaskDto> clientDtos = _taskRepository.GetTaskByOrderId(Id);

            var result = _mapper.Map<List<TaskOutputModel>>(clientDtos);

            return result;
        }
        public void UpdateStatusTaskByTaskId(int taskId, Status newTaskStatus) 
        {
            _taskRepository.UpdateTaskStatus(taskId, newTaskStatus);
        }
        public void RemoveTask(int id)
        {
            throw new NotImplementedException();
        }
        public List<TaskOutputModel> GetAllTask()
        {
            List<TaskDto> tasks = _taskRepository.GetAllTasks();
            List<TaskOutputModel> result = _mapper.Map<List<TaskOutputModel>>(tasks);

            return result;
        }
        public TaskOutputModel GetTaskById(int Id)
        {
          TaskDto tasks =_taskRepository.GetTaskById(Id);
          TaskOutputModel result =_mapper.Map<TaskOutputModel>(tasks);

            return result;
        }
        public List<TaskOutputModel> FilterTasks( DateTime? startDate,DateTime? endDate)
        {
            List<TaskDto> task = _taskRepository.FilterTasks(startDate, endDate);
            List<TaskOutputModel> result = _mapper.Map<List<TaskOutputModel>>(task);
            return result;
        }
        public List<TaskOutputModel> GetTaskByMasterId(int MasterId)
        {
            List<TaskDto> tasks = _taskRepository.GetTaskByMasterId(MasterId);
            List<TaskOutputModel> result = _mapper.Map<List<TaskOutputModel>>(tasks).ToList();
            return result;
        }

        public void AddTask(TaskInputModel task, int orderId)
        {
             _taskRepository.AddTask(_mapper.Map<TaskDto>(task), orderId);
        }

    }
}
