using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface IOrderRepository
    {
        public Task<OrderDto> AddOrder(OrderDto order);

        public Task<IEnumerable<OrderDto>> GetAllOrders();

        public Task<IEnumerable<OrderDto>> GetAllApplications();

        public Task<OrderDto> GetOrderById(int id);

        public Task<OrderDto> UpdateOrder(OrderDto order);
    }
}