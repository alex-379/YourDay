using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourDay.DAL.Dtos
{
    public class UserProfilesPictureDto
    {
        public int Id { get; set; }

        [MaxLength(4000)]
        public string Link { get; set; }

        [ForeignKey("UserId")]
        public UserDto? User { get; set; }
    }
}