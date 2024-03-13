namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public int OrderId { get; set; }

        public string Date { get; set; }

        public string TimeStart { get; set; }

        public string TimeEnd { get; set; }

        public int SpecializationId { get; set; }

        public int StatusId { get; set; }
    }
}