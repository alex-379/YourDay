using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.Models.OutputModels
{
    public class ReceiveTasksByEmployeeOutputModel
    {
        public int MasterId { get; set; }
        public int NumberOfTasks { get; set; }
        public int FromWhatTask { get; set; }
        public int DirectionSortByDate { get; set; }
    }

    public class UpdateTaskStatusOutputModel
    {
        public string Status { get; set; }
        public int TaskId { get; set; }
    }
}
