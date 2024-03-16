using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Enums
{
    public enum Statuses
    {
        [Display(Name = "Получен")]
        Received,

        [Display(Name = "В работе")]
        InProgress,

        [Display(Name = "Завершён")]
        Completed,

        [Display(Name = "Отменён")]
        Cancelled
    }
}