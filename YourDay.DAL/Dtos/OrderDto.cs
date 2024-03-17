using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string OrderName { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public int? CountPeople { get; set; }

        public int Price { get; set; }

        public int Еvaluation { get; set; }

        public UserDto? Client { get; set; }

        public UserDto? Manager { get; set; }

        public Status? Status { get; set; }

        public IEnumerable<TaskDto>? Tasks { get; set; }

        public IEnumerable<HistoryDto>? Histories { get; set; }
    }
}
