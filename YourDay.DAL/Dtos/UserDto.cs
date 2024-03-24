using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Mail { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        public byte[] Hash { get; set; }

        public byte[] Salt { get; set; }

        public bool IsDeleted { get; set; }

        public Role Role { get; set; }

        public IEnumerable<SpecializationDto>? Specializations { get; set; }

        public IEnumerable<OrderDto>? Orders { get; set; }

        public IEnumerable<TaskDto>? WorkerTasks { get; set; }

        public UserProfilesPictureDto Picture { get; set; }
    }
}
