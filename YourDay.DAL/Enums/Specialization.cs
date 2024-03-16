using System.ComponentModel.DataAnnotations;

namespace YourDay.DAL.Enums
{
    public enum Specialization
    {
        [Display(Name = "Флорист")]
        Florist,

        [Display(Name = "Оформитель")]
        Decorator,

        [Display(Name = "Грузчик")]
        Loader,

        [Display(Name = "Дизайнер")]
        Designer,

        [Display(Name = "Аниматор")]
        Animator
    }
}