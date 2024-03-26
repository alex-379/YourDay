using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;
using YourDay.BLL.Clients;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Service;
using YourDay.Components.Pages.Manager;
using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.Repositories;


Context context = SingletoneStorage.GetStorage().Сontext;

UserRepository userRepository = new UserRepository();
OrderRepository orderRepository = new OrderRepository();
TaskRepository taskRepository = new TaskRepository();

UserService userService = new UserService();
TaskService taskService = new TaskService();

var order3 = orderRepository.GetOrderById(5);
var q = new TaskDto()
{
    Title = "кошька2",
    Status = Status.InProgress,
    TimeStart = DateTime.Now,
    TimeEnd = DateTime.Now.AddMinutes(18),
    //Workers = [w],
    //Order = order3,
    Description = "гав",
    //Specialization = s


};
//context.Tasks.Add(q);
//q.Order = order3;

taskRepository.AddTask(q, 5);
context.SaveChanges();

//UserInputModel w = userService.GetWorkerById(1015);

//var c = new UserInputModel()
//{
//    UserName = "СОБАКА ",
//    Mail="AAA",
//    Password="11",
//    Phone="000",
//    IsDeleted=false,
//    Role = Role.Worker

//};


//SpecializationIntputModel s = new SpecializationIntputModel()
//{
//    Name="Кинолог"
//};
//var o = new OrderForManagerInputModel()
//{
//    OrderName = "ГАВ ГАВ ГАВ ",
//    Address = "Москва",
//    Date = new DateTime(2024, 5, 5),
//    CountPeople = 120,
//    Price = 100000,
//    //Еvaluation = 1,
//    Status = Status.Received,
//};



//context.Tasks.Add(q);
//context.SaveChanges();
//taskService.AddTask(q);

//Console.WriteLine();

//var t = taskRepository.GetTaskByMasterId(4);
//u.UserName = "Филипп";
//u.Password = "testpassws";
//var tmp = rep.DeleteUser(u);
//Console.WriteLine();

//context.Users.Add(u);
//context.SaveChanges();

//Role role = Role.Worker;
//var users = context.Users
//                .Include(c => c.Specializations)
//                .Where(u => u.Role == role).ToList();

//var o2 = context.Orders
//    .Include(o => o.Client)
//    .Include(o => o.Manager)
//    .Include(o => o.Histories)
//    .Include(o => o.Tasks)
//    .Where(o => o.Id == 5).Single();
//Console.WriteLine();


//var order2 = context.Orders.Where(m => m.Id == 2).Single();


//var s = context.Specializations.Where(s => s.Id == 2).Single();
//var o = context.Orders.Where(o => o.Id == 2).Single();
//var w = context.Users.Where(m => m.Id == 4).ToList();

//var sp = context.SpecializationDtoUserDto
//{
//    SpecializationsId = 2,
//    WorkersId = 3
//};
//context.Tasks.Add(sp);
//context.SaveChanges();


//var tasks = context.Tasks.Where(m => m.OrderId == 2).ToList();



//context.SaveChanges();


//Console.WriteLine(1);






//var client = context.Users.Where(c => c.Id == 10).Single();
//var manager = context.Users.Where(m => m.Id == 9).Single();

//var o = new OrderDto()
//{
//    OrderName = "Концерт",
//    Address = "Москва",
//    Date = new DateTime(2024, 5, 5),
//    CountPeople = 120,
//    Price = 100000,
//    Еvaluation = 1,
//    Status = Status.Received,
//    Client = client,
//    Manager = manager
//};

//context.Orders.Add(o);

//var orders = context.Orders; //можем вывести все зака







////var t = context.Tasks.Where(t => t.Id == 1).Single();
////t.Description = "Привезти букет из 5 роз";

////t.Workers = w;



////context.Tasks.Update(t);

//context.SaveChanges();