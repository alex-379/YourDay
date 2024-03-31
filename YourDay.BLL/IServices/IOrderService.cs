using YourDay.BLL.Enums;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IOrderService
    {
        public OrderOutputModel AddOrder(OrderForManagerInputModel order);

        public IEnumerable<OrderOutputModel> GetAllOrders();

        public IEnumerable<OrderNameDateOutputModel> GetAllOrdersForCard();

        public List<OrderNameDateOutputModel> ShowAllCompletedAndCanselledOrdersForCard(IEnumerable<OrderNameDateOutputModel> orders);

        public OrderOutputModel GetOrderById(int id);

        public OrderInputModel GetOrderByIdForAddTask(int id);

        public void UpdateOrderStatus(int orderId, StatusUI newOrderStatus);
    }
}