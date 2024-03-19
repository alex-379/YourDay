using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;

namespace YourDay.DAL.Repositories
{
    public class TaskRepository
    {
        public Context context;
        public TaskRepository()
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
        }
        public List<TaskDto> GetTaskByOrderId(int Id)
        {
            Context context = SingletoneStorage.GetStorage().Сontext;
            List<TaskDto> tasks = context.Tasks.Where(m => m.OrderId == Id).ToList();
            return tasks;
        }
    }
}
