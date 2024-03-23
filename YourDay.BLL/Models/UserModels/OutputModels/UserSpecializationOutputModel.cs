using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class UserSpecializationOutputModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public IEnumerable<SpecializationOutputModel> Specializations { get; set; }
    }
}
