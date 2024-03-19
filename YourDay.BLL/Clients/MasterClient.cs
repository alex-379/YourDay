using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.DAL.Dtos;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.DAL.IRepositories;
using AutoMapper;
using System.Collections.Generic;

namespace YourDay.BLL.Clients
{
    public class MasterClient : IMasterService
    {
        private MasterRepository _masterRepository;
        private Mapper _mapper;

        public MasterClient() 
        {
            _masterRepository = new MasterRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfilecs());
            });
            _mapper = new Mapper(config);
        }

        public List<TaskOutputModel> GetAllTask()
        {
            List<TaskDto> task = _masterRepository.GetAllTasks();

            List<TaskOutputModel> result = this._mapper.Map<List<TaskOutputModel>>(task);

            return result; ;
        }

        public TaskOutputModel GetTaskByMasterId(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTasksStatusByTaskId(UpdateTaskStatusInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
