using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

Context context = SingletoneStorage.GetStorage().Сontext;

var u = new UserDto()
{
    UserName = "Анна",
    Mail = "asd@gmail.com",
    Phone = "+9212975643",
    Password = "1234",
    IsDeleted = false,
    Role = Role.Manager
};
//context.Users.Add(u);

var client = context.Users.Where(c => c.Role == Role.Client).Single();
var manager = context.Users.Where(m => m.Role == Role.Manager).Single();

var o = new OrderDto()
{
    OrderName = "День рождения",
    Address = "Москва",
    Date =  new DateTime(2024,5,5),
    CountPeople = 12,
    Price = 10000,
    //Еvaluation = 1,
    Status = Status.Received,
    Client = client,
    Manager = manager
};


string d = o.Date.ToShortDateString();
Console.WriteLine(d);


context.Orders.Add(o);

context.SaveChanges();

Console.WriteLine();

//o.Client = client;
//o.Manager = manager;