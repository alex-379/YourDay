

using YourDay.BLL.Models.MenagerModels.OutputModel;

namespace YourDay.BLL.IServices
{
    public interface IManagerService
    {
        public List<MenagerNameAndPhoneOutputModel> GetAllMenagers();
    }
}
