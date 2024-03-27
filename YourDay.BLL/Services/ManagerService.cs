using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IUserRepository _managerRepository;
        private readonly Mapper _mapper;

        public ManagerService()
        {
            _managerRepository = new UserRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public IEnumerable<ManagerNameAndPhoneOutputModel> GetAllManagers()
        {
            var usersDtoManager = _managerRepository.GetAllUsersByRole(Role.Manager);
            var managers = _mapper.Map<IEnumerable<ManagerNameAndPhoneOutputModel>>(usersDtoManager);

            return managers;
        }
    }
}