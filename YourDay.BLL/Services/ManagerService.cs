using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.DAL;
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

        public async Task<IEnumerable<ManagerNameAndPhoneOutputModel>> GetAllManagers()
        {
            var usersDtoManager = await _userRepository.GetAllUsersByRole(Role.Manager);
            var managers = _mapper.Map<IEnumerable<ManagerNameAndPhoneOutputModel>>(usersDtoManager);

            return managers;
        }
        public async Task<OrderOutputModel> AddManagerIdToOrder(int managerId, int orderId)
        {
            UserDto manager = await _userRepository.GetUserById(managerId);
            OrderDto order = await _orderRepository.GetOrderById(orderId);
            order.Manager = manager;
            _orderRepository.UpdateOrder(order);
        }

        public async Task<OrderOutputModel> AddTaskManager(TaskDto task, int orderId)
        {
            context.Tasks.Add(task);
            task.Order = orderRepository.GetOrderById(orderId);
            context.SaveChanges();
        }
    }
}