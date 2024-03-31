using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;

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

        public List<OrderDto> GetAllOrders()
        {
            List<OrderDto> orders = context.Orders.ToList();

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