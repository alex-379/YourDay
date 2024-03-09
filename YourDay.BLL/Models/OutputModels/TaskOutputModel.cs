namespace YourDay.BLL.Models.OutputModels
{
    public class TaskOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string WorkerName { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}
