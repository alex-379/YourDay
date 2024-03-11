using YourDay.BLL.Models.InputModels;
using YourDay.BLL;

List<OrderInputModel> qqq = new List<OrderInputModel>();
ManagerClient client = new ManagerClient();
qqq = client.GetAllOrders();
DateOnly date1 = new DateOnly(2020, 9, 20);
client.AddOrderFields(qqq, "qqqq", date1);
qqq = client.GetAllOrders();



Console.ReadLine();