using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class UserAuthorizationOutputModel
    {
        public string Mail { get; set; }

        public byte[] Hash { get; set; }

        public byte[] Salt { get; set; }

        public Role Role { get; set; }
    }
}