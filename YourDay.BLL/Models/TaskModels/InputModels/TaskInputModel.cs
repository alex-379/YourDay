using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YourDay.BLL.Enums;

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

        public SpecializationTaskInputModel? Specialization { get; set; }

        public StatusUI? Status { get; set; }
    }
}