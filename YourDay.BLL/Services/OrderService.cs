using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class OrderService : IOrderService
    {
        private OrderRepository _orderRepository;
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

        public OrderOutputModel AddOrder(OrderForManagerInputModel order)
        {
            OrderDto orderDtoOutput = _orderRepository.AddOrder(_mapper.Map<OrderDto>(order));
            OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtoOutput);

            return orderOutput;
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

        public OrderOutputModel GetOrderById(int id)
        {
            OrderDto orderDto = _orderRepository.GetOrderById(id);
            OrderOutputModel order = _mapper.Map<OrderOutputModel>(orderDto);

            return order;
        }

        public static string? GetDateStringForOrder(DateTime? date)
        {
            string? dateString = date?.ToString("dd/MM/yyyy");

            return dateString;
        }
    }
}
