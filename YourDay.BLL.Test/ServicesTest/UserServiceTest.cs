using AutoMapper;
using YourDay.BLL.Enums;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.BLL.Test.IRepositories;
using YourDay.BLL.Test.Repositories;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class UserServiceTest
    {
        public IUserRepositoryTest Repository { get; set; }

        private readonly Mapper _mapper;
        private readonly IPasswordService _passwordService;

        public UserServiceTest()
        {
            Repository = new UserRepositoryTest();
            _passwordService = new PasswordService();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public UserOutputModel GetUserById(int userId)
        {
            UserDto userDto = Repository.GetUserById(userId);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public UserOutputModel DeleteUser(int userId)
        {
            UserDto user = Repository.GetUserById(userId);
            user.IsDeleted = true;
            UserDto userDtoOutput = Repository.UpdateUser(user);
            UserOutputModel userOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return userOutput;
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

        private IEnumerable<UserMailOutputModel> GetAllMailBoxes()
        {
            var userDtos = Repository.GetAllUsers();
            var mails = _mapper.Map<IEnumerable<UserMailOutputModel>>(userDtos);

            return mails;
        }

        private IEnumerable<UserAuthorizationOutputModel> GetAllMailBoxesWithPasswords()
        {
            var userDtos = Repository.GetAllUsers();
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