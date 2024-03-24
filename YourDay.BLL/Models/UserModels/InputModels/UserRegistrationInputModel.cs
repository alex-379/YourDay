using System.ComponentModel.DataAnnotations;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserRegistrationInputModel
    {
        [Required(ErrorMessage = "Введите значение в поле")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите значение в поле")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Введите значение в поле")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Введите значение в поле")]
        public string Password { get; set; }
    }
}