using System.Collections.Immutable;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;




namespace YourDay.DAL.Repositories
{
    public class MasterRepository : IMasterRepository
    {
        public Context context;
        public MasterRepository() 
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
        }
        
        public List<UserDto> GetAllMasters(Role master) 
        {
            List<UserDto> users = context.Users.Where(master=>master.Role==Role.Worker).ToList();
            return users;
        }
        public List<UserDto> GetMasterById(int id)
        {
            
            List<UserDto> users = context.Users.Where(master=>master.Id==id).ToList();
            return users;
        }
        public List<TaskDto> GetTaskByMasterId(int id)
        {
          
            List<TaskDto> tasks=context.Tasks.Where(master=>master.WorkersId.ToList().Contains(id)).ToList();
            return tasks;
        }

    }
}
