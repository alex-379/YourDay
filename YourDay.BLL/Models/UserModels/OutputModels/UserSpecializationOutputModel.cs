using YourDay.BLL.Models.SpecializationModels.OutputModels;

namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class UserSpecializationOutputModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public IEnumerable<SpecializationOnlyNameOutputModel> Specializations { get; set; }
    }
}