using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.OrderModels.OutputModels
{
    public class OrderNameDateOutputModel
    {
        public int Id { get; set; }

        public string? OrderName { get; set; }

        public string? Date { get; set; }

        public StatusUI Status { get; set; }
    }
}