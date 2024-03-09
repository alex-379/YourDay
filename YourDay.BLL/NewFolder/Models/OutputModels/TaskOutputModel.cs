using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.NewFolder.Models.OutputModels
{
    public class TaskOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkerName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
