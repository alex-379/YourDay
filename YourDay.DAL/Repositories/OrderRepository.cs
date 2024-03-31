using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace YourDay.DAL.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public OrderDto AddOrder(OrderDto order)
        {
            order.Status = Status.Received;
            context.Orders.Add(order);
            context.SaveChanges();

            return order;
        }

        public IEnumerable<OrderDto> GetAllOrders()
        {
            IEnumerable<OrderDto> orders = context.Orders.Where(o=>o.Manager!=null);

            return orders;
        }

        public OrderDto GetOrderById(int id)
        {
            OrderDto order = context.Orders.Where(o => o.Id == id)
                .Include(order => order.Manager).Single();

            return order;
        }

        public OrderDto UpdateOrder(OrderDto order)
        {
            context.Orders.Update(order);
            context.SaveChanges();

            return order;
        }

        public void UpdateOrderStatus(int orderId, Status newOrderStatus)
        {
            OrderDto order = context.Orders.Single(order => order.Id == orderId);

            if (order != null)
            {
                order.Status = newOrderStatus;
            }

            context.SaveChanges();
        }
    }
}