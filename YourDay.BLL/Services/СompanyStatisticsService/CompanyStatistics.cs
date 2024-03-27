using AutoMapper;
using YourDay.DAL.Repositories;


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
        List<Co>

    }
}
