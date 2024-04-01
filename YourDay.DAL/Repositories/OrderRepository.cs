using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace YourDay.DAL.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public async Task<OrderDto> AddOrder(OrderDto order)
        {
            order.Status = Status.Received;
            context.Orders.Add(order);
            context.SaveChanges();

            return order;
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersWithManager()
        {
            var orders = await context.Orders.AsQueryable().Where(o=>o.Manager!=null).ToListAsync();

            return orders;
        }

        public async Task<IEnumerable<OrderDto>> GetAllApplications()
        {
            var orders = await context.Orders.AsQueryable().Where(o=>o.Status==Status.Received).ToListAsync();

            return orders;
        }

        public async Task<OrderDto> GetOrderById(int id)
        {
            OrderDto order = await context.Orders.AsQueryable().Where(o => o.Id == id)
                .Include(order => order.Manager).SingleAsync();

            return order;
        }

        public async Task<OrderDto> UpdateOrder(OrderDto order)
        {
            context.Orders.Update(order);
            await context.SaveChangesAsync();

            return order;
        }
    }
}