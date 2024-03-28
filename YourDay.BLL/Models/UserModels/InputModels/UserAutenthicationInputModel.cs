using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserAutenthicationInputModel
    {
        public string Mail { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
