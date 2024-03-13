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

        private List<OrderNameDataOutputModel> _outputNewModels;

        public OrderServiceMock()
        {
            _outputModels = new List<OrderOutputModel>()
            {
                new OrderOutputModel()
                {
                    Id = 1,
                    OrderName = "День рожения",
                    ClientName="Анна",
                    Date="20.11.2022",
                    CountPeople=13,
                    Adress="Новосибирск",
                    Comments="Очень далеко"
                },
                new OrderOutputModel()
                {
                    Id = 2,
                    OrderName = "Новый год",
                    ClientName="Иван Васильевич",
                    Date="20.06.2024",
                    CountPeople=4,
                    Adress="Лесная поляна",
                    Comments="Какой новый год сейчас лето"
                },
                new OrderOutputModel()
                {
                    Id = 3,
                    OrderName = "Выпускной",
                    ClientName="Юлия Эдуардовна",
                    Date="11.09.2023",
                    CountPeople=45,
                    Adress="Школа",
                    Comments="Очень много людей"
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

        public List<OrderNameDataOutputModel> GetAllOrdersOnlyNameData()
        {
            return _outputNewModels;
        }

        public OrderOutputModel GetOrderById(int id)
        {
            return _outputModels[id - 1];
        }
    }
}

