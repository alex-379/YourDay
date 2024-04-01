using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserInputModel
    {
        public string UserName { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }

        public RoleUI Role { get; set; }
    }
}