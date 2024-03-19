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
