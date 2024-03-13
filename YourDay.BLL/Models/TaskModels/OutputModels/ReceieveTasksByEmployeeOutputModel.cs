namespace YourDay.BLL.Models.TaskModels.OutputModels
{
    public class ReceieveTasksByEmployeeOutputModel
    {
        public int MasterId { get; set; }

        public int NumberOfTasks { get; set; }

        public int FromWhatTask { get; set; }

        public int DirectionSortByDate { get; set; }
    }
}