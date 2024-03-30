using System.ComponentModel.DataAnnotations;

namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class SpecializationOutputModel
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}
