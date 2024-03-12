using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.InputModels;
using YourDay.BLL.Models.OutputModels;

namespace YourDay.BLL
{
    public class OrderServiceMock: IOrderService
    {
        private List<OrderOutputModel> _outputModels;

        public OrderServiceMock()
        {
            _outputModels = new List<OrderOutputModel>()
            {
                new OrderOutputModel()
                {
                    Id = 1,
                    OrderName = "Test",
                    ClientName="aa",
                    Date="20.11.2022",
                    CountPeople=13,
                    Adress="adress",
                    Comments="help"
                },
                new OrderOutputModel()
                {
                    Id = 2,
                    OrderName = "qqqq",
                    ClientName="b",
                    Date="20.11.2022",
                    CountPeople=13,
                    Adress="adress",
                    Comments="iii"
                },
                new OrderOutputModel()
                {
                    Id = 3,
                    OrderName = "qqqq",
                    ClientName="ccc",
                    Date="200000",
                    CountPeople=45,
                    Adress="adress",
                    Comments="herrlp"
                },
            };
        }

        public OrderOutputModel AddOrder(OrderInputModel order)
        {
            return new OrderOutputModel()
            {
                Id = 1,
                OrderName = order.OrderName,
                ClientName = order.ClientName,
                Date = order.Date,
                CountPeople = order.CountPeople,
                Adress = order.Adress,
                Comments = order.Comments
            };
        }

        public List<OrderOutputModel> GetAllOrders()
        {
            return _outputModels;
        }

        public OrderOutputModel GetOrderById(int id)
        {
            return _outputModels[id - 1];
        }
    }
}

