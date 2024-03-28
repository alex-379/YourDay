using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;

namespace YourDay.DAL.Repositories
{
    public class CompanyStatisticsRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public List<TaskDto> GetAllTaskOfOrderOfTheirManager ()
        {
            List<TaskDto> tasksWithOrdersAndManagers = context.Tasks
                 .Include(task => task.Order)
                 .Include(task => task.Order.Manager)
                 .ToList();

           return tasksWithOrdersAndManagers;
        }
    }
}