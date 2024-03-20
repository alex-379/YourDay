using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.DAL.Dtos;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.OutputModels;

namespace YourDay.BLL.Clients
{
    public class MasterService : IMasterService
    {
        private MasterRepository _masterRepository;
        private Mapper _mapper;

        public MasterService() 
        {
            _masterRepository = new MasterRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = new Mapper(config);
        }
        public List<MasterOutputModel> GetAllMasters()
        {
            List<UserDto> users = (List<UserDto>)_masterRepository.GetAllMasters(DAL.Enums.Role.Worker);
            List<MasterOutputModel> result = _mapper.Map<List<MasterOutputModel>>(users);
            return result;
        }

        public List<MasterOutputModel> GetTaskByMasterId(int id)
        {
            List<TaskDto> taskDtos = _masterRepository.GetTaskByMasterId(id);
            List<MasterOutputModel> result = _mapper.Map<List<MasterOutputModel>>(taskDtos);
            return result;
        }

        public List<MasterOutputModel> GetUserByMasterId(int id)
        {
            List<UserDto> users = _masterRepository.GetMasterById(id);
            List<MasterOutputModel> result = _mapper.Map<List<MasterOutputModel>>(users);
            return result;
        }
    }
}
