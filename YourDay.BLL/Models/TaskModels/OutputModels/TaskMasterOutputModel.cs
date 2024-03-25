using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.Models.TaskModels.OutputModels
{
    public class TaskWorkerOutputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int OrderId { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public string Description { get; set; }

        public int SpecializationId { get; set; }

        public int StatusId { get; set; }
        public int WorkerId {  get; set; }
    }
}
