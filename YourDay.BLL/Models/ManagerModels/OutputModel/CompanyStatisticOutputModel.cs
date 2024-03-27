using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.ManagerModels.OutputModel
{
    public class CompanyStatisticOutputModel
    {
        public List<UserDto> Manager {  get; set; }
        public List<OrderDto> Orders { get; set; }
        public List<TaskDto> Tasks { get; set; }


    }
}
