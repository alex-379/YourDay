﻿using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface IOrderRepository
    {
        public OrderDto AddOrder(OrderDto order);

        public IEnumerable<OrderDto> GetAllOrders();

        public IEnumerable<OrderDto> GetAllApplications();

        public OrderDto GetOrderById(int id);

        public OrderDto UpdateOrder(OrderDto order);
    }
}
