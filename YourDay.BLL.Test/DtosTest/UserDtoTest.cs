using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Test.Dtos
{
    public class UserDtoTest
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Mail { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserDto dto &&
                   Id == dto.Id &&
                   UserName == dto.UserName &&
                   Mail == dto.Mail &&
                   Phone == dto.Phone;
        }
    }
}