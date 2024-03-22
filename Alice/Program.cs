using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL.Clients;
TaskRepository r = new TaskRepository();
var a = r.GetTaskByOrderId(5);

//OrderService c = new OrderService();
//var a1= c.GetTaskByOrderId(2);


Console.WriteLine("a");