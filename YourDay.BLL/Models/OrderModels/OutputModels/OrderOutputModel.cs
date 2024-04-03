using YourDay.BLL.Enums;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;


namespace YourDay.BLL.Models.OrderModels.OutputModels
{
    public class OrderOutputModel
    {
        public int Id { get; set; }

        public string? OrderName { get; set; }

        public string? Address { get; set; }

        public DateTime? Date { get; set; }

        public int? CountPeople { get; set; }

        public int Price { get; set; }

        public StatusUI Status { get; set; }

        public UserOutputModel? Manager { get; set; }

        public UserOutputModel? Client { get; set; }
    }
}