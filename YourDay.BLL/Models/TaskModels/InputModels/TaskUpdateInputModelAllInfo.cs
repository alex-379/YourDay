using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskUpdateInputModelAllInfo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public Status? Status { get; set; }

        public IEnumerable<UserDto>? Workers { get; set; }

        public OrderDto? Order { get; set; }

        public SpecializationDto? Specialization { get; set; }
    }
}
