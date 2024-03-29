using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class SpecializationService: ISpecializationService
    {
        private readonly ISpecializationRepository _specializationRepository;
        private readonly Mapper _mapper;

        public SpecializationService()
        {
            _specializationRepository = new SpecializationRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public SpecializationOnlyNameOutputModel AddSpecialization(SpecializationInputModel specialization)
        {
            SpecializationDto specializationDtoInput = _mapper.Map<SpecializationDto>(specialization);
            SpecializationDto specializationDtoOutput = _specializationRepository.AddSpecialization(specializationDtoInput);
            SpecializationOnlyNameOutputModel specializationOutput = _mapper.Map<SpecializationOnlyNameOutputModel>(specializationDtoOutput);

            return specializationOutput;
        }
    }
}