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

//var o = new OrderDto()
//{
//    OrderName = "День рождения",
//    Address = "Москва",
//    Date =  new DateTime(2024,5,5),
//    CountPeople = 12,
//    Price = 10000,
//    //Еvaluation = 1,
//    Status = Status.Received,
//    Client = client,
//    Manager = manager
//};


//string d = o.Date.ToShortDateString();
//Console.WriteLine(d);


//context.Orders.Add(o);

//context.SaveChanges();

//Console.WriteLine();

//var w1 = new UserDto()
//{
//    UserName = "Алексей",
//    Mail = "alex@gmail.com",
//    Phone = "+92129756431",
//    Password = "32432",
//    IsDeleted = false,
//    Role = Role.Worker
//};

//var w2 = new UserDto()
//{
//    UserName = "Андрей",
//    Mail = "andrew@mail.ru",
//    Phone = "+921297123",
//    Password = "ghgfdtr#43d1",
//    IsDeleted = false,
//    Role = Role.Worker
//};

//context.Users.Add(w1);
//context.Users.Add(w2);

var s = context.Specializations.Where(s => s.Id == 1).Single();
var o = context.Orders.Where(o => o.Id == 1).Single();
var w = context.Users.Where(u => u.Role == Role.Worker && u.Id == 3).ToList();

var t = new TaskDto()
{
    Order = o,
    Specialization = s,
    Status = Status.InProgress,
    TimeEnd = new DateTime(2024, 6, 15, 1, 17, 0),
    TimeStart = new DateTime(2024, 6, 12, 1, 12, 0),
    Workers = w,
    Description = "Украсить зал",
    Title = "Декорация"
};


//var t = context.Tasks.Where(t => t.Id == 1).Single();
//t.Description = "Привезти букет из 5 роз";

//t.Workers = w;

context.Tasks.Add(t);

//context.Tasks.Update(t);

context.SaveChanges();