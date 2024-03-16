using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IOrderService
    {
        public OrderOutputModel AddOrder(OrderInputModel order);

        public List<OrderOutputModel> GetAllOrders();

        public OrderOutputModel GetOrderById(int id);
    }
}