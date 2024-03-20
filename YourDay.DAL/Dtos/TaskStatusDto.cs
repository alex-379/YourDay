using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class TaskStatusDto
    {
        public Status Status { get; set; }
        public int TaskId { get; set; }
    }
}
