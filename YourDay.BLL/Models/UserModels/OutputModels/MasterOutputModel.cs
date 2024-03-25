using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class WorkerOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public Role   Worker {  get; set; }


    }
}
