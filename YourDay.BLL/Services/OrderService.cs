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
        private OrderRepository _orderRepository;
        private UserRepository _userRepository;
        private Mapper _mapper;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _userRepository = new UserRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public OrderOutputModel AddOrder(OrderForManagerInputModel order)
        {
            order.Status = StatusUI.Received;
            OrderDto orderDtoInput = _orderRepository.AddOrder(_mapper.Map<OrderDto>(order));
            OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtoInput);

            return orderOutput;
        }

        public void AddApplication(ApplicationInputModel application, string userMail)
        {
            HistoryDto historyDtoInput = _mapper.Map<HistoryDto>(application);
            historyDtoInput.DateTime = DateTime.Now;
            OrderDto orderDtoInput = new OrderDto();
            orderDtoInput.Histories = new List<HistoryDto>()
            {
            historyDtoInput
            };
            orderDtoInput.Client = _userRepository.GetUserByMail(userMail);
            _orderRepository.AddOrder(orderDtoInput);
        }

        public IEnumerable<OrderOutputModel> GetAllOrders()
        {
            var orderDtos = _orderRepository.GetAllOrders();
            var orders = _mapper.Map<IEnumerable<OrderOutputModel>>(orderDtos);

            return orders;
        }

        public IEnumerable<OrderNameDateOutputModel> GetAllOrdersForCard()
        {
            var orderDtos = _orderRepository.GetAllOrders();
            var orders = _mapper.Map<IEnumerable<OrderNameDateOutputModel>>(orderDtos);

            return orders;
        }

        public IEnumerable<OrderNameDateOutputModel> GetAllApplications()
        {
            var orderDtos = _orderRepository.GetAllApplications();
            var orders = _mapper.Map<IEnumerable<OrderNameDateOutputModel>>(orderDtos);

            return orders;
        }

        public List<OrderNameDateOutputModel> ShowAllCompletedAndCanselledOrdersForCard(IEnumerable<OrderNameDateOutputModel> orders)
        {
            List<OrderNameDateOutputModel> completedOrders = orders.Where(o => o.Status == StatusUI.Completed || o.Status == StatusUI.Canselled).ToList();

            return completedOrders;
        }

        public OrderOutputModel GetOrderById(int id)
        {
            OrderDto orderDto = _orderRepository.GetOrderById(id);
            OrderOutputModel order = _mapper.Map<OrderOutputModel>(orderDto);

            return order;
        }

        public OrderInputModel GetOrderByIdForAddTask(int id)
        {
            OrderDto orderDto = _orderRepository.GetOrderById(id);
            OrderInputModel order = _mapper.Map<OrderInputModel>(orderDto);

            return order;
        }

        public static string? GetDateStringForOrder(DateTime? date)
        {
            string? dateString = date?.ToString("dd/MM/yyyy");

            return dateString;
        }

        public void UpdateOrderStatus(int orderId, StatusUI newOrderStatus)
        {
            Status orderStatus = _mapper.Map<Status>(newOrderStatus);
            _orderRepository.UpdateOrderStatus(orderId, orderStatus);

        }
    }
}
