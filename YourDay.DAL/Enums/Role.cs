using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Enums
{
    public enum Role
    {
        [Display(Name = "Клиент")]
        Client = 0,

        [Display(Name = "Работник")]
        Worker = 1,

        [Display(Name = "Менеджер")]
        Manager = 2
    }
}