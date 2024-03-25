using AutoMapper;
using System.Security.Cryptography;
using System.Text;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        private readonly Mapper _mapper;
        private RandomNumberGenerator _rng;

        public UserService()
        {
            _userRepository = new UserRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);

            _rng = RandomNumberGenerator.Create();
        }

        public UserOutputModel RegisterClient(UserRegistrationInputModel client)
        {
            client.Salt = PasswordService.GetSalt();
            client.Hash = PasswordService.GetHash(client.Password, client.Salt);
            UserDto userDtoInput = _mapper.Map<UserDto>(client);
            userDtoInput.Role = Role.Client;
            userDtoInput.IsDeleted = false;
            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel clientOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return clientOutput;
        }

        public UserOutputModel AddClientForManager(UserAddForManagerInputModel client)
        {
            RNGCryptoServiceProvider.Create().GetBytes(client.Salt);
            UserDto userDtoInput = _mapper.Map<UserDto>(client);

            userDtoInput.Role = Role.Client;
            userDtoInput.IsDeleted = false;
            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel clientOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return clientOutput;
        }

        public UserOutputModel AddWorkerForManager(UserAddForManagerInputModel worker)
        {
            UserDto userDtoInput = _mapper.Map<UserDto>(worker);
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

        public IEnumerable<UserMailOutputModel> GetAllMailBoxes()
        {
            var userDtos = _userRepository.GetAllUsers();
            var mails = _mapper.Map<IEnumerable<UserMailOutputModel>>(userDtos);

            return mails;
        }

        public IEnumerable<UserAuthorizationOutputModel> GetAllMailBoxesWithPasswords()
        {
            var userDtos = _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserAuthorizationOutputModel>>(userDtos);

            return users;
        }

        public UserOutputModel GetUserById(int id)
        {
            UserDto userDto = _userRepository.GetUserById(id);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public static bool ConfirmMail(UserRegistrationInputModel client, IEnumerable<UserMailOutputModel> mails)
        {
            bool result = mails.Any(u => u.Mail == client.Mail);

            return result;
        }

        public static UserAuthorizationOutputModel FindUser(UserAutenthicationInputModel client, IEnumerable<UserAuthorizationOutputModel> users)
        {
            UserAuthorizationOutputModel user = users.Where(u => u.Mail == client.Mail).Single();

            return user;
        }

        public static bool ConfirmPassword(byte[] userInputHash, byte[] userDbHash)
        {
            bool result = (userInputHash.SequenceEqual(userDbHash));

            return result;
        }
    }
}