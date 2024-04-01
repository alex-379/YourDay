using YourDay.BLL.Enums;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface IOrderService
    {
        public Task<OrderOutputModel> AddOrder(OrderForManagerInputModel order);

        public Task<IEnumerable<OrderOutputModel>> GetAllOrders();

        public Task<IEnumerable<OrderNameDateOutputModel>> GetAllOrdersForCard();

        public Task<IEnumerable<OrderNameDateOutputModel>> GetAllApplications();

        public IEnumerable<OrderNameDateOutputModel> ShowAllCompletedAndCanselledOrdersForCard(IEnumerable<OrderNameDateOutputModel> orders);

        public Task<OrderOutputModel> GetOrderById(int id);

        public Task<OrderInputModel> GetOrderByIdForAddTask(int id);

        public Task<OrderOutputModel> UpdateOrderStatus(int orderId, StatusUI newOrderStatus);

        public string? GetDateStringForOrder(DateTime? date);
    }
}