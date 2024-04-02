using YourDay.BLL.Enums;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {







        public StatusUI? Status { get; set; }



        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(4000)]
        public string? Description { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime TimeStart { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime TimeEnd { get; set; }


    }
}