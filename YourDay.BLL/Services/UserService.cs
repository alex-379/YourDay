using AutoMapper;
using System.Security.Cryptography;
using System.Text;
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
        private readonly UserRepository _userRepository;
        private readonly Mapper _mapper;

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
            userDtoInput.Role = Role.Worker;
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

        private static byte[] GetSalt()
        {
            const int SaltLength = 64;
            Byte[] salt = new Byte[SaltLength];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(salt);

            return salt;
        }

        public static Tuple<byte[], byte[]> GetSaltHash(string password)
        {
            byte[] salt = GetSalt();
            byte[] passwordByte = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = passwordByte.Concat(salt).ToArray();
            byte[] hash = SHA256.HashData(saltedPassword);

            return Tuple.Create(salt, hash);
        }

        //public bool ConfirmPassword(UserModel)
        //{

        //}


        //public static bool ConfirmPassword(string password, byte[] hash, byte[] salt)
        //{
        //    byte[] passwordHash = Hash(password, _passwordSalt);

        //    return _passwordHash.SequenceEqual(passwordHash);
        //}

    }
}
