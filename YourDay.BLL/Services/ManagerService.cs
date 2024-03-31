using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly Mapper _mapper;
       
        public ManagerService()
        {
            _userRepository = new UserRepository();
            _orderRepository = new OrderRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public List<ManagerNameAndPhoneOutputModel> GetAllManagers()
        {
            List<UserDto> usersDtoManager = _userRepository.GetAllUsersByRole(Role.Manager).ToList();
            List<ManagerNameAndPhoneOutputModel> managers = _mapper.Map<List<ManagerNameAndPhoneOutputModel>>(usersDtoManager);

            return managers;
        }
        public void AddManagerIdToOrder(int managerId, int orderId)
        {
            UserDto manager = _userRepository.GetUserById(managerId);
            OrderDto order = _orderRepository.GetOrderById(orderId);
            order.Manager = manager;
            _orderRepository.UpdateOrder(order);
        }
    }
}