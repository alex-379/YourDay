using YourDay.DAL.Dtos;
namespace YourDay.DAL.Repositories
{
    public class OrderRepository
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
            var orders = context.Orders.ToList();
            return orders;
        }

        public OrderDto GetOrderById(int id)
        {
            OrderDto order = context.Orders.Where(o => o.Id == id).Single();
            return order;
        }
    }
}