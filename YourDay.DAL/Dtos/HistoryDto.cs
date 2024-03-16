namespace YourDay.DAL.Dtos
{
    public class HistoryDto
    {
        public int Id { get; set; }

        public List<OrderDto>? Order { get; set; }

        public DateTime DateTime { get; set; }

        public string Comment { get; set; }
    }
}
