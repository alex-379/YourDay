using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IOrderRepository
    {
        public Task<OrderDto> AddOrder(OrderDto order);

        public Task<IEnumerable<OrderDto>> GetAllOrdersWithManager();

        public Task<IEnumerable<OrderDto>> GetAllApplications();

        public Task<OrderDto> GetOrderById(int id);

        public Task<OrderDto> UpdateOrder(OrderDto order);
    }
}
