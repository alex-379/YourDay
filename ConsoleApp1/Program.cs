using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using YourDay.BLL.Enums;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Services;
using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = SingletoneStorage.GetStorage().Сontext;

            IUserRepository userRepository = new UserRepository();
            IOrderRepository orderRepository = new OrderRepository();
            ITaskRepository taskRepository = new TaskRepository();
            ISpecializationRepository specializationRepository = new SpecializationRepository();

            IOrderService orderService = new OrderService();
            IUserService userService = new UserService();
            ITaskService taskService = new TaskService();
            ISpecializationService specializationService = new SpecializationService();


            TaskInputModel a = new TaskInputModel()
            {
                TimeEnd = DateTime.Now,
                TimeStart = DateTime.Now,
                Title = "A",
                Description = "B",
                Status = Status.InProgress
            };

            //a.Order = orderService.GetOrderByIdForAddTask(8);
            taskService.AddTaskManager(a, 8);

            //context.Tasks.Add(a);
            //a.Order = orderRepository.GetOrderById(4);
            //context.SaveChanges();
            //var a = RoleUI.Manager.ToString();
            //var a = taskService.UpdateTaskStatusByTaskId(1, StatusUI.Canselled);
            //Console.WriteLine();

            //UserRegistrationInputModel model = new UserRegistrationInputModel()
            //{
            //    UserName = "Андрей",
            //    Mail = "worker1@yday.ru",
            //    Phone = "999999"
            //};

            //var a = userService.AddWorkerForManager(model);

            //var a = taskService.GetTasksByWorkerIdWithOrderWithSpecialization(9);
            //Console.WriteLine();

            //var b = taskService.GetTasksByWorkerIdWithOrderWithSpecialization(9);
            //var b = taskRepository.GetTaskByIdWithAll(10);
            //var t = userRepository.GetTestUserById()
            //Console.WriteLine();

            //var w = userRepository.GetUserById(9);
            //var t = taskRepository.GetTaskByIdWithAll(3);
            //var s = new List<UserDto>();
            //if (t.Workers == null)
            //{
            //    t.Workers = new List<UserDto>() { w };

            //}
            //else
            //{
            //    t.Workers.A = t.Workers.ToList();
            //    s.Add(w);


            //}
            //taskRepository.UpdateTask(t);

            //Console.WriteLine();

            //OrderDto order = orderRepository.GetOrderById(2);
            //SpecializationDto specialization = specializationRepository.GetSpecializationById(4);

            //TaskInputModel model = new()
            //{
            //    Description = "оформить помещение 4",
            //    Order = order,
            //    TimeStart = DateTime.Now,
            //    TimeEnd = new DateTime(2024, 6, 6, 12, 0, 0),
            //    Specialization = specialization,
            //    Title = "Оформление",
            //};

            //var a = taskService.AddTask(model);
            //var b = taskService.AddWorkerForTask(1, 9);

            //var c = userRepository.GetUserById(4);
            //c.UserName = "Владимир";
            //var d = userRepository.UpdateUser(c);
            //Console.WriteLine();

            //var u = new UserRegistrationInputModel()
            //{
            //    UserName = "Александра",
            //    Mail = "al@gmail.com",
            //    Phone = "+9212444556",
            //    Password = "md5data",
            //};

            //var a = userService.GetUserByIdByRole(2, Role.Manager);
            //Console.WriteLine();

            //SpecializationInputModel specialization = new()
            //{
            //    Name = "Аниматор",
            //};
            //specializationService.AddSpecialization(specialization);
            //SpecializationDto specialization = specializationRepository.GetSpecializationById(1);



            //var a = taskService.AddTask(model);

            //Console.WriteLine();

            //var result = taskService.GetTasksByWorkerIdWithOrderWithSpecialization(1);


            //Console.WriteLine();

            //UserAutenthicationInputModel model = new UserAutenthicationInputModel()
            //{
            //    Mail = "sergio@mail.ru",
            //    Password = "123456",
            //};

            //var a = userService.GetAllMailBoxesWithPasswords();
            //Console.WriteLine();

            //UserRegistrationInputModel model = new UserRegistrationInputModel()
            //{
            //    UserName = "Андрей",
            //    Mail = "andrew.mail@m.ru",
            //    Password = "231232112",
            //    Phone = "9095461232"
            //};
            //userService.AddUser(model);

            //var a = PasswordService.GetSalt();
            //Console.WriteLine(a);

            //int a = (int)Length.PasswordLength;
            //Console.WriteLine(a);

            //UserService.GetSaltHash("231312");

            //userRepository.GetAllUsers();
            //Console.WriteLine();

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

            //var t = taskRepository.GetTaskByWorkerId(4);
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
            //var w = context.Users.Where(m => m.Id == 9).ToList();

            //var t = new TaskDto()
            //{
            //    Status = Status.InProgress,
            //    TimeEnd = new DateTime(2024, 6, 16, 1, 18, 0),
            //    TimeStart = new DateTime(2024, 6, 17, 1, 13, 0),
            //    Description = "подготовка зала",
            //    Title = "зал"
            //};
            //context.Tasks.Add(t);
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
        }
    }
}