using Microsoft.EntityFrameworkCore;
using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.Repositories;


Context context = SingletoneStorage.GetStorage().Сontext;

UserRepository userRepository = new UserRepository();
OrderRepository orderRepository = new OrderRepository();

//var u = new UserDto()
//{
//    UserName = "Семён",
//    Mail = "oxxy@gmail.com",
//    Phone = "+921246565",
//    Password = "ghjhgf",
//    IsDeleted = false,
//    Role = Role.Manager
//};

//var tmp = rep.AddUser(u);

//Console.WriteLine();

var o = orderRepository.GetOrderByIdWithClientWithManagerWithStatus(4);
//u.UserName = "Филипп";
//u.Password = "testpassws";
//var tmp = rep.DeleteUser(u);
Console.WriteLine();

//context.Users.Add(u);
//context.SaveChanges();

//var o = context.Orders.Where(o => o.Id == 2).Single();
//var o2 = context.Orders
//    .Include(o => o.Client)
//    .Include(o => o.Manager)
//    .Include(o => o.Histories)
//    .Include(o => o.Tasks)
//    .Where(o => o.Id == 4).Single();
Console.WriteLine();

//var order3 = context.Orders.Where(order3 => order3.Id == 3).Single();
//var order2 = context.Orders.Where(m => m.Id == 2).Single();


//var s = context.Specializations.Where(s => s.Id == 2).Single();
//var o = context.Orders.Where(o => o.Id == 2).Single();
//var w = context.Users.Where(m => m.Id == 4).ToList();

//var t = new TaskDto()
//{
//    Order = order3,
//    Specialization = s,
//    Status = Status.InProgress,
//    TimeEnd = new DateTime(2024, 6, 15, 1, 17, 0),
//    TimeStart = new DateTime(2024, 6, 12, 1, 12, 0),
//    Workers = w,
//    Description = "много много цветов",
//    Title = "цветы"
//};
//context.Tasks.Add(t);


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