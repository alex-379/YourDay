using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL.Clients;
OrderRepository r = new OrderRepository();
var a = r.GetOrderById(2);

OrderClient c = new OrderClient();
var a1= c.GetOrderById(2);


Console.WriteLine("a");