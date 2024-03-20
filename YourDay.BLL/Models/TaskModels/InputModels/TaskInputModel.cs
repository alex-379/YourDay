using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public IEnumerable<UserDto>? Workers { get; set; }

        public OrderDto? Order { get; set; }

        public SpecializationDto? Specialization { get; set; }

        public Status? Status { get; set; }
    }
}