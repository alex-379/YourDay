using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Enums
{
    public enum Status
    {
        [Display(Name = "Получен")]
        Received = 0,

        [Display(Name = "В работе")]
        InProgress = 1,

        [Display(Name = "Завершён")]
        Completed = 2,

        [Display(Name = "Отменён")]
        Cancelled = 3
    }
}