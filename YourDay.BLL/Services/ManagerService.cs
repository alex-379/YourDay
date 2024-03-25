using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class ManagerService : IManagerService
    {
        private ManagerRepository _workerManagerRepository;
        private Mapper _mapper;

        public ManagerService()
        {
            _workerManagerRepository = new ManagerRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public List<ManagerNameAndPhoneOutputModel> GetAllManagers(Role Manager)
        {
            List<UserDto> userManager = _workerManagerRepository.GetAllManagers(Manager);
            List<ManagerNameAndPhoneOutputModel> result = _mapper.Map<List<ManagerNameAndPhoneOutputModel>>(userManager);
            return result;

        }
    }
}
