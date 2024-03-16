using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Enums
{
    public enum Roles
    {
        [Display(Name = "Менеджер")]
        Manager,

        [Display(Name = "Работник")]
        Worker,

        [Display(Name = "Клиент")]
        Client
    }
}