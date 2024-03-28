using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.TaskModels.OutputModels
{
    public class TaskOutputModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public OrderOutputModel Order { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public string Description { get; set; }

        public SpecializationOutputModel Specialization { get; set; }

        public Status Status { get; set; }
    }
}