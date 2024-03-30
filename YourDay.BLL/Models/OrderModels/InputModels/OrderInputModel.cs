using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.OrderModels.InputModels
{
    public class OrderInputModel
    {
        public string OrderName { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public int? CountPeople { get; set; }

        public int Price { get; set; }

        public Status Status { get; set; }
    }
}
