using AutoMapper;
using System.Text;
using XSystem.Security.Cryptography;
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

        public UserOutputModel RegisterClient(UserRegistrationInputModel client)
        {
            UserDto userDtoInput = _mapper.Map<UserDto>(client);
            userDtoInput.Role = Role.Client;
            userDtoInput.IsDeleted = false;

            string password = userDtoInput.Password;
            var data = Encoding.ASCII.GetBytes(password);
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(data);

            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel clientOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return clientOutput;
        }

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client)
        {
            UserDto userDtoInput = _mapper.Map<UserDto>(client);

            userDtoInput.Role = Role.Client;
            userDtoInput.IsDeleted = false;
            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel clientOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return clientOutput;
        }

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel client)
        {
            UserDto userDtoInput = _mapper.Map<UserDto>(client);
            userDtoInput.Role = Role.Client;
            userDtoInput.IsDeleted = false;
            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel clientOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return clientOutput;
        }

        public IEnumerable<UserOutputModel> GetAllUsers()
        {
            var userDtos = _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserOutputModel>>(userDtos);

            return users;
        }

        public UserOutputModel GetUserById(int id)
        {
            UserDto userDto = _userRepository.GetUserById(id);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }
    }
}
