using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Mapping;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Clients
{
    public class OrderClient
    {
        private OrderRepository _orderRepository;
        private Mapper _mapper;

        public OrderClient()
        {
            _orderRepository = new OrderRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new OrderMappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public List<OrderOutputModel> GetAllOrders()
        {
            List<OrderDto> clientDtos = _orderRepository.GetAllOrders();

            var result = _mapper.Map<List<OrderOutputModel>>(clientDtos);

            return result;
        }

        public List<OrderOutputModel> GetOrderById(int Id)
        {
            List<OrderDto> clientDtos = _orderRepository.GetOrderById(Id);

            var result = _mapper.Map<List<OrderOutputModel>>(clientDtos);

            return result;
        }
    }
}
