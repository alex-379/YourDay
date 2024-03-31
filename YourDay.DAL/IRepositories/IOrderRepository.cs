using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IOrderRepository
    {
        public OrderDto AddOrder(OrderDto order);

        public IEnumerable<OrderDto> GetAllOrders();

        public OrderDto GetOrderById(int id);

        public OrderDto UpdateOrder(OrderDto order);

        public void UpdateOrderStatus(int orderId, Status newOrderStatus);
    }
}
