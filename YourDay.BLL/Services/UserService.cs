using AutoMapper;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
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

        public UserOutputModel AddUser(UserRegistrationInputModel user)
        {
            this.GetSaltHash(user);
            UserDto userDtoInput = _mapper.Map<UserDto>(user);
            this.SetRole(userDtoInput, Role.Client);
            this.SetIsUndeleted(userDtoInput);
            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public UserOutputModel AddClientForManager(UserRegistrationInputModel client)
        {
            client.Password = PasswordService.GetRandomPassword();
            UserOutputModel clientOutput = this.AddUser(client);

            return clientOutput;
        }

        public UserOutputModel AddWorkerForManager(UserRegistrationInputModel worker)
        {
            worker.Password = PasswordService.GetRandomPassword();
            this.GetSaltHash(worker);
            UserDto userDtoInput = _mapper.Map<UserDto>(worker);
            this.SetRole(userDtoInput, Role.Worker);
            this.SetIsUndeleted(userDtoInput);
            UserDto userDtoOutput = _userRepository.AddUser(userDtoInput);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public IEnumerable<UserOutputModel> GetAllUsers()
        {
            var userDtos = _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserOutputModel>>(userDtos);

            return users;
        }

        public UserOutputModel GetUserById(int userId)
        {
            UserDto userDto = _userRepository.GetUserById(userId);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public IEnumerable<UserOutputModel> GetAllUsersByRole(Role role)
        {
            var usersDtoRole = _userRepository.GetAllUsersByRole(role);
            var usersRole = _mapper.Map<IEnumerable<UserOutputModel>>(usersDtoRole);

            return usersRole;
        }

        public bool ConfirmMail(UserRegistrationInputModel user)
        {
            var mails = this.GetAllMailBoxes();
            bool result = mails.Any(u => u.Mail == user.Mail);

            return result;
        }

        public bool ConfirmPassword(UserAutenthicationInputModel user)
        {
            var mails = this.GetAllMailBoxesWithPasswords();
            var userDb = mails.Where(u => u.Mail == user.Mail).Single();
            var hash = PasswordService.GetHash(user.Password, userDb.Salt);
            bool result = (hash.SequenceEqual(userDb.Hash));
            user.Role = userDb.Role;

            return result;
        }

        private UserDto SetRole(UserDto user, Role role)
        {
            user.Role = role;

            return user;
        }

        private UserDto SetIsUndeleted(UserDto user)
        {
            user.IsDeleted = false;

            return user;
        }

        private IEnumerable<UserMailOutputModel> GetAllMailBoxes()
        {
            var userDtos = _userRepository.GetAllUsers();
            var mails = _mapper.Map<IEnumerable<UserMailOutputModel>>(userDtos);

            return mails;
        }

        private IEnumerable<UserAuthorizationOutputModel> GetAllMailBoxesWithPasswords()
        {
            var userDtos = _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserAuthorizationOutputModel>>(userDtos);

            return users;
        }

        private UserRegistrationInputModel GetSaltHash(UserRegistrationInputModel user)
        {
            user.Salt = PasswordService.GetSalt();
            user.Hash = PasswordService.GetHash(user.Password, user.Salt);

            return user;
        }
    }
}