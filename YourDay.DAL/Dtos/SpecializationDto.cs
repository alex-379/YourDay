using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Dtos
{
    public class SpecializationDto
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public IEnumerable<UserDto>? Workers { get; set; }
    }
}