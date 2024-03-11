using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Models.OutputModels;
using YourDay.BLL.Models.InputModels;

namespace YourDay.BLL
{
    public class ManagerClient
    {
        public List<OrderInputModel> orderInputModels;
        public DateOnly date1;

        public ManagerClient()
        {
            DateOnly date1 = new DateOnly(2015, 7, 20);
            orderInputModels = new List<OrderInputModel>();
            orderInputModels.Add(new OrderInputModel());
            orderInputModels[0].Id = 1;
            orderInputModels[0].OrderName = "День рождения";
            orderInputModels[0].ClientName = "Аня";
            orderInputModels[0].Adress = "Москва";
            orderInputModels[0].Date = date1;
            orderInputModels[0].CountPeople = 23;
            orderInputModels[0].Comments = "много людей";

            orderInputModels.Add(new OrderInputModel());
            orderInputModels[1].Id = 2;
            orderInputModels[1].OrderName = "Новый год";
            orderInputModels[1].ClientName = "Михаил Сергеевич";
            orderInputModels[1].Adress = "Новосибирск";
            orderInputModels[0].Date = date1;
            orderInputModels[1].CountPeople = 3;
            orderInputModels[1].Comments = "мало людей";
        }

        public List<OrderInputModel> GetAllOrders()
        {

            var result = orderInputModels;

            return result;
        }

        public void AddOrder(OrderInputModel order)
        {
            orderInputModels.Add((OrderInputModel)order);

        }

        public void AddOrderFields(List<OrderInputModel> model, string Name, DateOnly Date)
        {
            model.Add(new OrderInputModel());
            model[model.Count].OrderName = Name;
            model[model.Count].Date = Date;
        }
    }
}
