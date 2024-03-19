using AutoMapper;
using YourDay.BLL.Models;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Mapping
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderDto, OrderOutputModel>();
        }
    }
}
