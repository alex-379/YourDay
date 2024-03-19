using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;
using AutoMapper;

namespace YourDay.BLL.Clients
{
    public class MasterClient
    {
        private MasterRepository _masterRepository;
        private _mapper;

        public MasterClient() 
        {
            _masterRepository = new MasterRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new OrderMappingProfile());
            });
            _mapper = new Mapper(config);
        }
    }
}
