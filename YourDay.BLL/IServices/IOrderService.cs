using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IOrderService
    {
        public OrderOutputModel AddOrder(OrderForManagerInputModel order);

        public IEnumerable<OrderOutputModel> GetAllOrders();

        public IEnumerable<OrderNameDateOutputModel> GetAllOrdersForCard();

        public List<OrderNameDateOutputModel> ShowAllCompletedOrdersForCard(IEnumerable<OrderNameDateOutputModel> orders);

        public OrderOutputModel GetOrderById(int id);

        public OrderInputModel GetOrderByIdForAddTask(int id);
    }
}