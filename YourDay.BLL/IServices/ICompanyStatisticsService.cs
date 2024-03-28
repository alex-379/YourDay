using YourDay.BLL.Models.CompanyModels.OutputModels;

namespace YourDay.BLL.IServices
{
    internal interface ICompanyStatisticsService
    {
        public List<CompanyStatisticOutputModel> GetAllTaskOfOrderOfTheirManager();
    }
}
