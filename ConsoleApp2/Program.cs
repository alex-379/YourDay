using YourDay.BLL.Services;
using YourDay.DAL.Repositories;

UserRepository userrep = new UserRepository();
TaskService t = new TaskService();


var tasks = await t.GetTaskById(22);


ManagerService m = new ManagerService();
var a = await m.GetAllWorkersForTask(tasks);
var w = 8;