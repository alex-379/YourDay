using YourDay.BLL.Clients;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.BLL.Service;
using YourDay.DAL;
using YourDay.DAL.Repositories;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime? birthdate = null;
            //var a = birthdate?.ToString("dd/MM/yyyy");
            //Console.WriteLine();

            Context context = SingletoneStorage.GetStorage().Сontext;

            UserRepository userRepository = new UserRepository();
            OrderRepository orderRepository = new OrderRepository();
            TaskRepository taskRepository = new TaskRepository();

            OrderService orderService = new OrderService();
            UserService userService = new UserService();
            TaskService taskService = new TaskService();

            UserService.GetSaltHash("231312");

            //string password2 = "123213213211";

            //var p1 = UserService.GetHashPassword(password1);
            //var p2 = UserService.GetHashPassword(password2);

            //string password = "123213213211";

            //var salt = UserService.GetSalt();
            //var hash = UserService.GetHash(password, salt);
            //var hash1 = UserService.GetHash(password1, salt);
            //var hash2 = UserService.GetHash(password2, salt);

            //var a = hash.SequenceEqual(hash1);
            //var b = hash.SequenceEqual(hash2);
            //var c = hash1.SequenceEqual(hash2);
            //var d = hash2.SequenceEqual(hash1);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //UserRegistrationInputModel client = new()
            //{
            //    Mail = ""
            //};

            //var mails = userService.GetAllMailBoxes();
            //var m = UserService.ConfirmMail(client, mails);

            //Console.WriteLine(m);

            //var user = userRepository.GetUserById(1050);
            //if (user.Password == md5data)
            //{
            //    Console.WriteLine("sadasdsadsa");
            //}

            //var u = new UserDto()
            //{
            //    UserName = "Семён",
            //    Mail = "oxxy@gmail.com",
            //    Phone = "+921246565",
            //    Password = md5data,
            //    IsDeleted = false,
            //    Role = Role.Client
            //};

            //var tmp = userRepository.AddUser(u);

            //Console.WriteLine();

            //var t = taskRepository.GetTaskByMasterId(4);
            //u.UserName = "Филипп";
            //u.Password = "testpassws";
            //var tmp = rep.DeleteUser(u);
            //Console.WriteLine();

            //context.Users.Add(u);
            //context.SaveChanges();

            //var o = context.Orders.Where(o => o.Id == 2).Single();
            //var o2 = context.Orders
            //    .Include(o => o.Client)
            //    .Include(o => o.Manager)
            //    .Include(o => o.Histories)
            //    .Include(o => o.Tasks)
            //    .Where(o => o.Id == 4).Single();
            //Console.WriteLine();

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

        }
    }
}
