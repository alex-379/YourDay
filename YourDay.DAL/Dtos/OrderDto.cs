using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        public UserDto ClientId { get; set; }

        public UserDto ManagerId { get; set; }

        public Statuses StatusId { get; set; }

        public string OrderName { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public int? CountPeople { get; set; }

        public int Price { get; set; }

        public int Еvaluation { get; set; }

        public List<TaskDto>? Tasks { get; set; }

        public HistoryDto? Histories { get; set; }
    }
}
