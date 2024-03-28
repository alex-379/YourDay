using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Enums
{
    public enum StatusUI
    {
        [Display(Name = "Получен")]
        Received = Status.Received,

        [Display(Name = "В работе")]
        InProgress = Status.InProgress,

        [Display(Name = "Завершён")]
        Completed = Status.Completed,

        [Display(Name = "Отменён")]
        Canselled = Status.Cancelled
    }
}