using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class WorkerRegistrationInputModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Mail { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        //public Role Role { get; set; }
    }
}
