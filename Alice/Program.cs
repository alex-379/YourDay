using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL.Service;
using YourDay.DAL.Enums;
UserRepository r = new UserRepository();

 //r.DeleteWorkerById(10);





UserService c = new UserService();
c.DeleteWorkerById(1018);



//Console.WriteLine("a");
//хотим еще выводить специализацию 