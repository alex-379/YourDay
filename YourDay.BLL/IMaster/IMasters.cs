using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.IMaster.Models;
using YourDay.BLL.Models.OutputModels;

namespace YourDay.BLL.IMaster
{
    public interface IMasters
    {
        public List<TaskOutputModel> GetAllOrders();
        public TaskOutputModel UpdateStatusTask(TaskInputModel model);
        //public TaskOutputModel GetTaskById(int Id);

        //public List<> GetScheduleByDay(DateTime? day);

    }
}
