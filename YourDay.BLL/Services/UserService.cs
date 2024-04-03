using AutoMapper;
using YourDay.BLL.Enums;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
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
        private readonly IPasswordService _passwordService;
        private readonly Mapper _mapper;

        public UserService()
        {
            _userRepository = new UserRepository();
            _passwordService = new PasswordService();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public async Task<UserOutputModel> AddUser(UserRegistrationInputModel user)
        {
            this.GetSaltHash(user);
            UserDto userDtoInput = _mapper.Map<UserDto>(user);
            this.SetRole(userDtoInput, Role.Client);
            this.SetIsUndeleted(userDtoInput);
            UserDto userDtoOutput = await _userRepository.AddUser(userDtoInput);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public async Task<UserOutputModel> AddClientForManager(UserRegistrationForManagerInputModel client)
        {
            client.Password = _passwordService.GetRandomPassword();
            this.GetSaltHashForManager(client);
            UserDto userDtoInput = _mapper.Map<UserDto>(client);
            this.SetRole(userDtoInput, Role.Client);
            this.SetIsUndeleted(userDtoInput);
            UserDto userDtoOutput = await _userRepository.AddUser(userDtoInput);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public async Task<UserOutputModel> AddWorkerForManager(UserRegistrationForManagerInputModel worker)
        {
            worker.Password = _passwordService.GetRandomPassword();
            this.GetSaltHashForManager(worker);
            UserDto userDtoInput = _mapper.Map<UserDto>(worker);
            this.SetRole(userDtoInput, Role.Worker);
            this.SetIsUndeleted(userDtoInput);
            UserDto userDtoOutput = await _userRepository.AddUser(userDtoInput);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public async Task<UserOutputModel> AddManager(UserRegistrationForManagerInputModel manager)
        {
            manager.Password = _passwordService.GetRandomPassword();
            this.GetSaltHashForManager(manager);
            UserDto userDtoInput = _mapper.Map<UserDto>(manager);
            this.SetRole(userDtoInput, Role.Manager);
            this.SetIsUndeleted(userDtoInput);
            UserDto userDtoOutput = await _userRepository.AddUser(userDtoInput);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public async Task<IEnumerable<UserOutputModel>> GetAllUsers()
        {
            var userDtos = await _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserOutputModel>>(userDtos);

            return users;
        }

        

        public async Task<IEnumerable<UserOutputModel>> GetAllUsersByRole(RoleUI role)
        {
            var userDtos = await _userRepository.GetAllUsersByRole((Role)role);
            var users = _mapper.Map<IEnumerable<UserOutputModel>>(userDtos);

            return users;
        }

        public async Task<IEnumerable<UserSpecializationOutputModel>> GetAllUsersSpecializationByRole(RoleUI role)
        {
            var userDtos = await _userRepository.GetAllUsersByRole((Role)role);
            var users = _mapper.Map<IEnumerable<UserSpecializationOutputModel>>(userDtos);

            return users;
        }

        public async Task<UserOutputModel> GetUserById(int userId)
        {
            UserDto userDto = await _userRepository.GetUserById(userId);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public async Task<UserOutputModel> DeleteUser(int userId)
        {
            UserDto user = await _userRepository.GetUserById(userId);
            user.IsDeleted = true;
            UserDto userDtoOutput = await _userRepository.UpdateUser(user);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
        }

        public async Task<bool> ConfirmMail(UserRegistrationInputModel user)
        {
            var mails = await this.GetAllMailBoxes();
            bool result = mails.Any(u => u.Mail == user.Mail);

            return result;
        }

        public async Task<bool> ConfirmPassword(UserAutenthicationInputModel user)
        {
            var mails = await this.GetAllMailBoxesWithPasswords();
            var userDb = mails.Where(u => u.Mail == user.Mail.ToLower()).Single();
            var hash = _passwordService.GetHash(user.Password, userDb.Salt);
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

        private async Task<IEnumerable<UserMailOutputModel>> GetAllMailBoxes()
        {
            var userDtos = await _userRepository.GetAllUsers();
            var mails = _mapper.Map<IEnumerable<UserMailOutputModel>>(userDtos);

            return mails;
        }

        private async Task<IEnumerable<UserAuthorizationOutputModel>> GetAllMailBoxesWithPasswords()
        {
            var userDtos = await _userRepository.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserAuthorizationOutputModel>>(userDtos);

            return users;
        }

        private UserRegistrationInputModel GetSaltHash(UserRegistrationInputModel user)
        {
            user.Salt = _passwordService.GetSalt();
            user.Hash = _passwordService.GetHash(user.Password, user.Salt);

            return user;
        }

        private UserRegistrationForManagerInputModel GetSaltHashForManager(UserRegistrationForManagerInputModel user)
        {
            user.Salt = _passwordService.GetSalt();
            user.Hash = _passwordService.GetHash(user.Password, user.Salt);

            return user;
        }
    }
}