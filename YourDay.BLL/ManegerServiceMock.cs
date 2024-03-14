
using YourDay.BLL.IServices;
using YourDay.BLL.Models.MenagerModels.OutputModel;

namespace YourDay.BLL
{
    public class ManegerServiceMock : IManagerService
    {
        private List<MenagerNameAndPhoneOutputModel> _managers;

        public ManegerServiceMock() 
        {
            _managers = new List<MenagerNameAndPhoneOutputModel>()
            {
                new MenagerNameAndPhoneOutputModel
                {
                    Name="Александр",
                    Phone="2345"
                },
                new MenagerNameAndPhoneOutputModel
                {
                    Name="Екатерина",
                    Phone="7806"
                },
                new MenagerNameAndPhoneOutputModel
                {
                    Name="Тимофей",
                    Phone="454657"
                }
            };
        }
        public List<MenagerNameAndPhoneOutputModel> GetAllMenagers()
        {
            return _managers;
        }
    }
}
