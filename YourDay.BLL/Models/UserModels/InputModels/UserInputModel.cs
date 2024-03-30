using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserInputModel
    {
        public string UserName { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }

        public Role Role { get; set; }
    }
}
