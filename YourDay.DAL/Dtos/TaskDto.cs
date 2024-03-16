namespace YourDay.DAL.Dtos
{
    public class TaskDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int SpecizlizationId { get; set; }

        public int StatusId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public List<UserDto>? Workers { get; set; }
    }
}
