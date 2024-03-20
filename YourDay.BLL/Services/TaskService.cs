using AutoMapper;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.IServices;
using YourDay.DAL.Enums;

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
            List<TaskDto> clientDtos = _taskRepository.GetTaskByOrderId(Id);

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
        public List<TaskOutputModel> GetTaskById(int Id)
        {
            List<TaskDto> taskDtos = _taskRepository.GetTaskById(Id);
            List<TaskOutputModel> result =_mapper.Map<List<TaskOutputModel>>(taskDtos);
            return result;

        }



    }
}
