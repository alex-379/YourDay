using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.DAL;
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

        public SpecializationTaskInputModel GetSpecializationById(int id)
        {
            SpecializationDto specialization = _specializationRepository.GetSpecializationById(id);
            SpecializationTaskInputModel specializationModel = _mapper.Map<SpecializationTaskInputModel>(specialization);

            return specializationModel;
        }

        public IEnumerable<SpecializationIdNameOutputModel> GetAllSpecialization()
        {
            IEnumerable<SpecializationDto> specializations = _specializationRepository.GetAllSpecialization();
            IEnumerable<SpecializationIdNameOutputModel> specializationModel = _mapper.Map<IEnumerable<SpecializationIdNameOutputModel>>(specializations);

            return specializationModel;
        }
    }
}