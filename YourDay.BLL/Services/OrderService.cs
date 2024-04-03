using AutoMapper;
using YourDay.BLL.Enums;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private Mapper _mapper;

        public OrderService()
        {
            _orderRepository = new OrderRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public async Task<OrderOutputModel> AddOrder(OrderForManagerInputModel order)
        {
            order.Status = StatusUI.Received;
            OrderDto orderDtoInput = await _orderRepository.AddOrder(_mapper.Map<OrderDto>(order));
            OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtoInput);

            return orderOutput;
        }

        public async Task<IEnumerable<OrderOutputModel>> GetAllOrders()
        {
            var orderDtos = await _orderRepository.GetAllOrders();
            var orders = _mapper.Map<IEnumerable<OrderOutputModel>>(orderDtos);

            return orders;
        }

        public async Task<IEnumerable<OrderNameDateOutputModel>> GetAllOrdersForCard()
        {
            var orderDtos = await _orderRepository.GetAllOrders();

            var orders = _mapper.Map<IEnumerable<OrderNameDateOutputModel>>(orderDtos);

            return orders;
        }

        public async Task<IEnumerable<ApplicationOutputModel>> GetAllApplications()
        {
            var orderDtos = await _orderRepository.GetAllApplications();
            var orders = _mapper.Map<IEnumerable<ApplicationOutputModel>>(orderDtos);

            return orders;
        }

        public IEnumerable<OrderNameDateOutputModel> ShowAllCompletedAndCanselledOrdersForCard(IEnumerable<OrderNameDateOutputModel> orders)
        {
            var completedOrders = orders.Where(o => o.Status == StatusUI.Completed || o.Status == StatusUI.Canselled);

            return completedOrders;
        }

        public IEnumerable<OrderNameDateOutputModel> ShowAllInProgressOrdersForCard(IEnumerable<OrderNameDateOutputModel> orders)
        {
            var currentOrders = orders.Where(o => o.Status == StatusUI.InProgress);

            return currentOrders;
        }

        public async Task<OrderOutputModel> GetOrderById(int id)
        {
            OrderDto orderDto = await _orderRepository.GetOrderById(id);
            OrderOutputModel order = _mapper.Map<OrderOutputModel>(orderDto);

            return order;
        }

        public async Task<OrderInputModel> GetOrderByIdForAddTask(int id)
        {
            OrderDto orderDto = await _orderRepository.GetOrderById(id);
            OrderInputModel order = _mapper.Map<OrderInputModel>(orderDto);

            return order;
        }

        public async Task<OrderOutputModel> UpdateOrderStatus(int orderId, StatusUI newOrderStatus)
        {
            OrderDto orderDto = await _orderRepository.GetOrderById(orderId);
            orderDto.Status = (Status)newOrderStatus;
            OrderDto orderDtoInput = await _orderRepository.UpdateOrder(orderDto);
            OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtoInput);

            return orderOutput;
        }
    }
}
