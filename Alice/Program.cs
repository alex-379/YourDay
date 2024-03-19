using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL;
OrderRepository r = new OrderRepository();
var a = r.GetAllOrders();

OrderClient c = new OrderClient();
var a1= c.GetAllOrdersMap();


Console.WriteLine("a");