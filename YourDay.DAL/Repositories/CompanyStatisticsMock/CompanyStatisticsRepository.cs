using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;

namespace YourDay.DAL.Repositories
{
    public class CompanyStatisticsRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public List<OrderDto> GetManagerOrders(UserDto manager)
        {
            List<OrderDto> orders = context.Orders
                .Where(order => order.Manager.Id == manager.Id) // Фильтруем заказы по менеджеру

                .Select(order => new OrderDto

                {
                    Manager =order.Manager,

                    Status = order.Status,

                    OrderName = order.OrderName,

                    Tasks = order.Tasks.Select(task => new TaskDto
                    {
                        Id = task.Id,

                        Status = task.Status,

                    }).ToList(),
                }).ToList();

            return orders;
        }
    }
}
