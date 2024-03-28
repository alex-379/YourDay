using AutoMapper;
using YourDay.DAL.Repositories;
using YourDay.DAL.Dtos;
using YourDay.BLL.Models.CompanyModels.OutputModels;
using YourDay.BLL.IServices;



namespace YourDay.BLL.Services
{
    public class CompanyStatisticsService: ICompanyStatisticsService
    {
        private readonly CompanyStatisticsRepository _statisticsRepository;
        private readonly Mapper _mapper;

        public CompanyStatisticsService()
        {
            _statisticsRepository = new CompanyStatisticsRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

         public List<CompanyStatisticOutputModel> GetAllTaskOfOrderOfTheirManager()
        {
            List<TaskDto> tasks = _statisticsRepository.GetAllTaskOfOrderOfTheirManager();
            List<CompanyStatisticOutputModel> result = _mapper.Map<List<CompanyStatisticOutputModel>>(tasks);
            return result;
        }
    }
}
