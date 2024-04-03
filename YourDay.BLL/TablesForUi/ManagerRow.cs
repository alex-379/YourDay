using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.TablesForUi
{
    public class ManagerRow
    {
        public int ManagerId { get; set; }
        public string? ManagerName { get; set; }
        public IEnumerable<OrderRow> TasksByOrder { get; set; }
    }
}
