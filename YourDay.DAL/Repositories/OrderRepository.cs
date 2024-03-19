using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
namespace YourDay.DAL.Repositories
{
    public class OrderRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public IEnumerable<OrderDto> GetAllOrdersWithClientWithManagerWithStatus()
        {
            var orders = context.Orders
                .Include(o=>o.Client)
                .Include(o => o.Manager)
                .ToList();
            return orders;
        }

        public OrderDto GetOrderByIdWithClientWithManagerWithStatus(int id)
        {
            var order = context.Orders
                .Include(o => o.Client)
                .Include(o => o.Manager)
                .Where(o => o.Id == id)
                .Single();
            return order;
        }

        //public Context context;
        //public OrderRepository() {

        //    Context context = SingletoneStorage.GetStorage().Сontext;
        //}
        public IEnumerable<OrderDto> GetAllOrders()
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            List<OrderDto> orders = context.Orders.ToList();
            return orders;
        }

        public List<OrderDto> GetOrderById(int Id)
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            List<OrderDto> orders = context.Orders.Where(m => m.Id == Id).ToList();
            return orders;
        }
    }
}
