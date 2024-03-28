using AutoMapper;
using YourDay.DAL.Repositories;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.DAL.Dtos;



namespace YourDay.BLL.Services
{
    public class CompanyStatistics
    {
        private readonly CompanyStatisticsRepository _statisticsRepository;
        private readonly Mapper _mapper;

        public CompanyStatistics()
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
