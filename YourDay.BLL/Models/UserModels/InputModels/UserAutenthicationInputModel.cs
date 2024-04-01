using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserAutenthicationInputModel
    {
        public string Mail { get; set; }

        public string Password { get; set; }

        public RoleUI Role { get; set; }
    }
}