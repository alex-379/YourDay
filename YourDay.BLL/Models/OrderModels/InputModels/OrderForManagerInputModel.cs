using System.ComponentModel.DataAnnotations;
using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.OrderModels.InputModels
{
    public class OrderForManagerInputModel
    {
        public string OrderName { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Выберите дату не более, чем на месяц вперёд")]
        public DateTime Date { get; set; }

        public int? CountPeople { get; set; }

        public int Price { get; set; }

        public StatusUI Status { get; set; }
    }
}