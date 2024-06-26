﻿using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class SpecializationService : ISpecializationService
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

        public async Task<SpecializationOutputModel> AddSpecialization(SpecializationInputModel specialization)
        {
            SpecializationDto specializationDtoInput = _mapper.Map<SpecializationDto>(specialization);
            SpecializationDto specializationDtoOutput = await _specializationRepository.AddSpecialization(specializationDtoInput);
            SpecializationOutputModel specializationOutput = _mapper.Map<SpecializationOutputModel>(specializationDtoOutput);

            return specializationOutput;
        }

        public async Task<SpecializationTaskInputModel> GetSpecializationById(int id)
        {
            var specialization = await _specializationRepository.GetSpecializationById(id);
            SpecializationTaskInputModel specializationModel = _mapper.Map<SpecializationTaskInputModel>(specialization);

            return specializationModel;
        }



        public async Task<IEnumerable<SpecializationOutputModel>> GetAllSpecialization()
        {
            var specializations = await _specializationRepository.GetAllSpecialization();
            var specializationModel = _mapper.Map<IEnumerable<SpecializationOutputModel>>(specializations);

            return specializationModel;
        }
    }
}