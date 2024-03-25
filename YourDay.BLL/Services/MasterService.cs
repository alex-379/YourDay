using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Clients
{
    public class WorkerService : IWorkerService
    {
        private WorkerRepository _workerRepository;
        private Mapper _mapper;

        public WorkerService()
        {
            _workerRepository = new WorkerRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = new Mapper(config);
        }
        public List<WorkerOutputModel> GetAllWorkers()
        {
            List<UserDto> users = (List<UserDto>)_workerRepository.GetAllWorkers(DAL.Enums.Role.Worker);
            List<WorkerOutputModel> result = _mapper.Map<List<WorkerOutputModel>>(users);

            return result;
        }

        public List<WorkerOutputModel> GetTaskByWorkerId(int id)
        {
            List<TaskDto> taskDtos = _workerRepository.GetTaskByWorkerId(id);
            List<WorkerOutputModel> result = _mapper.Map<List<WorkerOutputModel>>(taskDtos);

            return result;
        }

        public List<WorkerOutputModel> GetUserByWorkerId(int id)
        {
            List<UserDto> users = _workerRepository.GetWorkerById(id);
            List<WorkerOutputModel> result = _mapper.Map<List<WorkerOutputModel>>(users);

            return result;
        }
    }
}
