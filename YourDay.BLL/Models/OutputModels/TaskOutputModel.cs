namespace YourDay.BLL.Models.OutputModels
{
    public class TaskOutputModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int OrderId { get; set; }

        public string Date { get; set; }

        public string TimeStart { get; set; }

        public string TimeEnd { get; set; }

        public int SpecializationId { get; set; }

        public string Status { get; set; }
    }
}
