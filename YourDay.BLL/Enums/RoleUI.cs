using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Enums
{
    public enum RoleUI
    {
        [Display(Name = "Клиент")]
        Client = Role.Client,

        [Display(Name = "Работник")]
        Worker = Role.Worker,

        [Display(Name = "Менеджер")]
        Manager = Role.Manager
    }
}