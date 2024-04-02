using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace YourDay.DAL.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        public async Task<OrderDto> AddOrder(OrderDto order)
        {
            using (Context context = new Context())
            {
                context.Orders.Add(order);
                await context.SaveChangesAsync();

                return order;
            }
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrders()
        {
            using (Context context = new Context())
            {
                var orders = await context.Orders.AsQueryable().Where(o => o.Status != Status.Received).ToListAsync();

                return orders;
            }
        }

        public async Task<IEnumerable<OrderDto>> GetAllApplications()
        {
            using (Context context = new Context())
            {
                var orders = await context.Orders.Include(o=>o.Histories).AsQueryable().Where(o => o.Status == Status.Received).ToListAsync();

                return orders;
            }
        }

        public async Task<OrderDto> GetOrderById(int id)
        {
            using (Context context = new Context())
            {
                OrderDto order = await context.Orders.AsQueryable().Where(o => o.Id == id)
                    .Include(order => order.Manager).SingleAsync();

                return order;
            }
        }

        public async Task<OrderDto> UpdateOrder(OrderDto order)
        {
            using (Context context = new Context())
            {
                context.Orders.Update(order);
                await context.SaveChangesAsync();

                return order;
            }
        }
    }
}