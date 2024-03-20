using AutoMapper;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using YourDay.BLL.Models.TaskModels.InputModels;

namespace YourDay.BLL.Clients
{
    public class TaskClient
    {
        private TaskRepository _taskRepository;
        private Mapper _mapper;

        public TaskClient()
        {
            _taskRepository = new TaskRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfilecs());
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
            TaskDto taskDto = this._mapper.Map<TaskDto>(taskStatus);
            this._taskRepository.UpdateTaskStatus(taskDto);
        }
    }
}
