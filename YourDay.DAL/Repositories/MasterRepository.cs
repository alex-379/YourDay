using YourDay.DAL.Dtos;
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
        public  List<TaskDto> GetAllTasks()
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            var tasks = context.Tasks.ToList();
            return tasks;
        }
        public void UpdateTasksStatusByTaskId(TaskDto model)
        {

        }
    }
}
