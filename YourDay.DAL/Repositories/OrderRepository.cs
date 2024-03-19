using YourDay.DAL.Dtos;
namespace YourDay.DAL.Repositories
{
    public class OrderRepository
    {
        public Context context;
        public OrderRepository() {

            Context context = SingletoneStorage.GetStorage().Сontext;
        }
        public List<OrderDto> GetAllOrders()
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            var orders = context.Orders.ToList();
            return orders;
        }
    }
}
