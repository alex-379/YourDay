
using YourDay.BLL.IServices;
using YourDay.BLL.Models.MenagerModels.OutputModel;

namespace YourDay.BLL
{
    public class ManegerServiceMock : IManagerService
    {
        private List<ManagerNameAndPhoneOutputModel> _managers;

        public ManegerServiceMock() 
        {
            _managers = new List<ManagerNameAndPhoneOutputModel>()
            {
                new ManagerNameAndPhoneOutputModel
                {
                    Name="Александр",
                    Phone="2345"
                },
                new ManagerNameAndPhoneOutputModel
                {
                    Name="Екатерина",
                    Phone="7806"
                },
                new ManagerNameAndPhoneOutputModel
                {
                    Name="Тимофей",
                    Phone="454657"
                }
            };
        }
        public List<ManagerNameAndPhoneOutputModel> GetAllMenagers()
        {
            return _managers;
        }
    }
}
