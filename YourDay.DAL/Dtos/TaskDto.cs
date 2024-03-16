using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class TaskDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public IEnumerable<UserDto>? Workers { get; set; }

        public OrderDto? OrderId { get; set; }

        public IEnumerable<Specialization>? Specializations { get; set; }

        public Status? Status { get; set; }
    }
}
