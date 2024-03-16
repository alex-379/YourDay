namespace YourDay.DAL.Dtos
{
    public class HistoryDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public DateTime DateTime { get; set; }

        public string Comment { get; set; }
    }
}
