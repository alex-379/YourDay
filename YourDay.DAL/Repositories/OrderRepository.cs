using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public OrderDto AddOrder(OrderDto order)
        {
            context.Orders.Add(order);
            context.SaveChanges();

            return order;
        }

        public IEnumerable<OrderDto> GetAllOrders()
        {
            IEnumerable<OrderDto> orders = context.Orders;

            return orders;
        }

        public IEnumerable<OrderDto> GetAllApplications()
        {
            IEnumerable<OrderDto> orders = context.Orders.Where(o=>o.Status==Status.Received).ToList();

            return orders;
        }

        public OrderDto GetOrderById(int id)
        {
            OrderDto order = context.Orders.Where(o => o.Id == id).Single();

            return order;
        }

        public OrderDto UpdateOrder(OrderDto order)
        {
            context.Orders.Update(order);
            context.SaveChanges();

            return order;
        }
    }
}