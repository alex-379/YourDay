namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public int OrderId { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public string Descriptions { get; set; }

        public int SpecializationId { get; set; }

        public int StatusId { get; set; }
    }
}