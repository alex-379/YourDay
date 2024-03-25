using System.ComponentModel.DataAnnotations;

namespace YourDay.BLL.Models.UserModels.InputModels
{
    public class UserAddForManagerInputModel
    {
        public string UserName { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public byte[] Hash { get; set; }

        public byte[] Salt { get; set; }
    }
}