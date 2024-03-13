using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Models.InputModels;
using YourDay.BLL.Models.OutputModels;
using YourDay.BLL.IServices;


namespace YourDay.BLL.IServices
{
    public interface IOrderService
    {
        public OrderOutputModel AddOrder(OrderInputModel order);

        public List<OrderOutputModel> GetAllOrders();

        public OrderOutputModel GetOrderById(int id);
    }
}
