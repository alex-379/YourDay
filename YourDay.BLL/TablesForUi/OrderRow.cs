using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.TablesForUi
{
    public  class OrderRow
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }

        public IGrouping<int, TaskRow> OrderTask { get; set; }
    }
}
