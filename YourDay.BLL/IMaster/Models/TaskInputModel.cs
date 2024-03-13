using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.IMaster.Models
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public int OrderId { get; set; }

        public string Date { get; set; }

        public string TimeStart { get; set; }

        public string TimeEnd { get; set; }

        public int SpecializationId { get; set; }

        public int StatusId { get; set; }
    }
}
