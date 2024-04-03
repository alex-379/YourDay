using System.ComponentModel.DataAnnotations;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class SpecializationTaskInputModel
    {
        [MaxLength(255)]
        public string Name { get; set; }
    }
}