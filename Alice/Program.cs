using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL.Service;
using YourDay.DAL.Enums;
using YourDay.BLL.Clients;
TaskRepository r = new TaskRepository();
var a = r.GetTaskByOrderId(1);
 //r.DeleteWorkerById(10);





TaskService c = new TaskService();
var b = c.GetTaskByOrderId(1);



Console.WriteLine("a");
//хотим еще выводить специализацию 