using YourDay.DAL.Repositories;
using YourDay.DAL;
using YourDay.BLL.Service;
using YourDay.DAL.Enums;
UserRepository r = new UserRepository();
Role b = new Role();
b = Role.Worker;
var a = r.GetAllUsersByRole(b);



var a2 = a.ToList();
var a3 = a2[0].Specializations;


UserService c = new UserService();
var a1 = c.GetAllUsersSpecializationByRole(b);


Console.WriteLine("a");
//хотим еще выводить специализацию 