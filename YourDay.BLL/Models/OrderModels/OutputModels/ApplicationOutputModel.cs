using YourDay.BLL.Models.HistoryModels.OutputModels;

namespace YourDay.BLL.Models.OrderModels.OutputModels
{
    public class ApplicationOutputModel
    {
        public int Id { get; set; }

        public IEnumerable<HistoryOutputModel>? Histories { get; set; }
    }
}