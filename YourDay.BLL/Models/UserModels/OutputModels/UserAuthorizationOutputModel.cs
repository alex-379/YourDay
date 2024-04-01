using YourDay.BLL.Enums;

namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class UserAuthorizationOutputModel
    {
        public string Mail { get; set; }

        public byte[] Hash { get; set; }

        public byte[] Salt { get; set; }

        public RoleUI Role { get; set; }
    }
}