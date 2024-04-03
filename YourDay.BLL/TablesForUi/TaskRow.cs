using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.TablesForUi
{
    public class TaskRow
    {
        public int ManagerId { get; set; }
        public int OrderId { get; set; }
        public string TaskName { get; set; }
        public string OrderName { get; set; }
    }
}
