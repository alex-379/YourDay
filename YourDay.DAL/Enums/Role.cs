using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Enums
{
    public enum Role
    {
        [Display(Name = "Менеджер")]
        Manager = 0,

        [Display(Name = "Работник")]
        Worker = 1,

        [Display(Name = "Клиент")]
        Client = 2
    }
}