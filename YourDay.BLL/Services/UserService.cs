using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Mapping;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Service
{
    public class UserService : IUserService
    {
        private UserRepository _userRepository;
        private Mapper _mapper;

        public UserService()
        {
            _userRepository = new UserRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public UserOutputModel AddUser(UserRegistrationInputModel user)
        {
            UserDto userDtoOutput = _userRepository.AddUser(_mapper.Map<UserDto>(user));
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public void AddWorker(UserRegistrationInputModel user)
        {
            UserDto a = _mapper.Map<UserDto>(user);
            _userRepository.AddWorker(a);
        }

        public IEnumerable<UserOutputModel> GetAllUsers()
        {
            var userDtos = _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserOutputModel>>(userDtos);

            return users;
        }

        public IEnumerable<UserOutputModel> GetAllUsersByRole(Role role)
        {
            var userDtos = _userRepository.GetAllUsersByRole(role);
            var users = _mapper.Map<IEnumerable<UserOutputModel>>(userDtos);

            return users;
        }

        public IEnumerable<UserSpecializationOutputModel> GetAllUsersSpecializationByRole(Role role)
        {
            var userDtos = _userRepository.GetAllUsersByRole(role);
            var users = _mapper.Map<IEnumerable<UserSpecializationOutputModel>>(userDtos);

            return users;
        }

        public UserOutputModel GetUserById(int id)
        {
            UserDto userDto = _userRepository.GetUserById(id);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public void DeleteWorkerById(int id)
        {
             _userRepository.DeleteWorkerById(id);
        }
    }
}
