using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public string? Description { get; set; }

        public TimeOnly TimeStart { get; set; }

        public TimeOnly TimeEnd { get; set; }

        public SpecializationTaskInputModel? Specialization { get; set; }

        public StatusUI? StatusUI { get; set; }
    }
}