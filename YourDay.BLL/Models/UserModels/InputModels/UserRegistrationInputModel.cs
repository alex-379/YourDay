using System.ComponentModel.DataAnnotations;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserRegistrationInputModel
    {
        [Required(ErrorMessage = "Введите Имя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите почту")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }

        public byte[] Hash { get; set; }

        public byte[] Salt { get; set; }
    }
}