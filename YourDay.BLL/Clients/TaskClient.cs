using AutoMapper;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.IServices;

namespace YourDay.BLL.Clients
{
    public class TaskClient:ITaskService
    {
        private TaskRepository _taskRepository;
        private Mapper _mapper;

        public TaskClient()
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
        public void UpdateStatusTaskByTaskId(UpdateTaskStatusInputModel taskStatus) 
        {
            //List<TaskDto> taskDto = this._taskRepository.UpdateTaskStatus();
            //List<UpdateTaskStatusInputModel> result = this._taskRepository.UpdateTaskStatus(taskDto);

            throw new NotImplementedException();
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

    }
}
