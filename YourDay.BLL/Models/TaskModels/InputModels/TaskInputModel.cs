using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {

        public string Title { get; set; }


        public string? Description { get; set; }

        public DateTime TimeStart { get; set; }


        public DateTime TimeEnd { get; set; }

        public SpecializationTaskInputModel? Specialization { get; set; }

        public StatusUI? StatusUI { get; set; }
    }
}