using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class TaskDto
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(4000)]
        public string? Description { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime TimeStart { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime TimeEnd { get; set; }

        public Status Status { get; set; }

        public List<UserDto>? Workers { get; set; }

        public OrderDto? Order { get; set; }

        public SpecializationDto? Specialization { get; set; }
    }
}
