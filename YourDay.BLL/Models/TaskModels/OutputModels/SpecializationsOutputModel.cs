using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.Models.TaskModels.OutputModels
{
    public class SpecializationsOutputModel
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}
