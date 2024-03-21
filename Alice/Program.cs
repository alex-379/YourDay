using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL.Clients;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.OrderModels.InputModels;
//OrderRepository r = new OrderRepository();
//var a = r.GetOrderById(2);

OrderForManagerInputModel m = new OrderForManagerInputModel();
m.CountPeople = 13;
m.Date = DateTime.Now;
m.Address = "Санкт-Петербург";
m.OrderName = "Выставка на день города";
m.Price = 109999;
m.Status = 0;

OrderService c = new OrderService();
c.AddOrder(m);


Console.WriteLine("a");