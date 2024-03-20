using System.Diagnostics;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YourDay.BLL
{
    public class OrderServiceMock : IOrderService
    {
        private List<OrderOutputModel> _outputModels;

        private List<OrderNameDateOutputModel> _outputNewModels;

        public OrderServiceMock()
        {
            _outputModels = new List<OrderOutputModel>()
            {
                //new OrderOutputModel()
                //{
                //    Id = 1,
                //    OrderName = "День рожения",
                //    ClientId =2,
                //    ManagerId = 1,
                //    Date="20.11.2022",
                //    CountPeople=13,
                //    Adress="Новосибирск",
                //    Comments="Очень далеко",
                //    StatusId = 1,
                //    Price = 999,

                //},
                //new OrderOutputModel()
                //{
                //    Id = 2,
                //    OrderName = "Новый год",
                //    ClientId =5,
                //    ManagerId = 1,
                //    Date="20.06.2024",
                //    CountPeople=4,
                //    Adress="Лесная поляна",
                //    Comments="Какой новый год сейчас лето",
                //    StatusId = 1,
                //    Price = 3456,


                //},
                //new OrderOutputModel()
                //{
                //    Id = 3,
                //    OrderName = "Выпускной",
                //    ClientId =4,
                //    ManagerId = 1,
                //    Date="11.09.2023",
                //    CountPeople=45,
                //    Adress="Школа",
                //    Comments="Очень много людей",
                //    StatusId = 1,
                //    Price = 999,


                //},
            };
        }

        public OrderOutputModel AddOrder(OrderForManagerInputModel order)
        {
            return new OrderOutputModel();
            //{
            //    Id = 1,
            //    OrderName = order.OrderName,
            //    ClientId = order.ClientId,
            //    ManagerId = order.ManagerId,
            //    Date = order.Date,
            //    CountPeople = order.CountPeople,
            //    Adress = order.Adress,
            //    Comments = order.Comments,
            //    StatusId = order.StatusId,
            //    Price = order.Price,

            //};
        }

        public List<OrderOutputModel> GetAllOrders()
        {
            return _outputModels;
        }

        public List<OrderNameDateOutputModel> GetAllOrdersOnlyNameData()
        {
            return _outputNewModels;
        }

        public OrderOutputModel GetOrderById(int id)
        {
            return _outputModels[id - 1];
        }
    }
}

