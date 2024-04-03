using Blazorise;
using YourDay.BLL.Enums;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.BLL.Services;
using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;
//UserService _userService = new UserService();
//var users = _userService.GetAllUsersByRoleAA(RoleUI.Client);
//int a = 8;


//UserRepository r = new UserRepository();
//Task<UserDto> n = r.GetUserById(2);
Context context = new Context();
UserDto user = context.Users.Where(c => c.Id == 59).Single();
if (user.WorkerTasks != null)
{
    user.WorkerTasks.Append(context.Tasks.Where(c => c.Id == 22).Single());
}