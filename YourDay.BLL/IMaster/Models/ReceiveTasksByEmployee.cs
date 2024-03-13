using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.IMaster.Models
{
    public class ReceiveTasksByEmployeeOutputModel
    {
        public int MasterId { get; set; }
        public int NumberOfTasks { get; set; }
        public int FromWhatTask { get; set; }
        public int DirectionSortByDate { get; set; }
    }
}
