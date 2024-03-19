using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string OrderName { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date { get; set; }

        public int? CountPeople { get; set; }

        public int Price { get; set; }

        public int? Еvaluation { get; set; }

        public UserDto? Client { get; set; }

        public UserDto? Manager { get; set; }

        public Status? Status { get; set; }

        public IEnumerable<TaskDto>? Tasks { get; set; }

        public IEnumerable<HistoryDto>? Histories { get; set; }

        public int? ClientId { get; set; }

        public int? ManagerId { get; set; }
    }
}
