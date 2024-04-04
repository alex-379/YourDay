using Moq;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.BLL.Services;
using YourDay.BLL.Test.Dtos;
using YourDay.BLL.Test.IRepositories;
using YourDay.BLL.Test.TestCaseSources;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Test
{
    [TestFixture]
    public class UserServiceTests
    {
        private UserServiceTest _service;
        private Mock<IUserRepositoryTest> _mock;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IUserRepositoryTest>();
            _service = new UserServiceTest();
            _service.Repository = _mock.Object;
        }

        [TestCaseSource(typeof(GetUserByIdTestCaseSourses))]
        public void GetUserById(int id, UserDto dto, UserOutputModel expected)
        {
            _mock.Setup(r => r.GetUserById(id)).Returns(dto);

            UserOutputModel actual = _service.GetUserById(id);



            Assert.AreEqual(expected, actual);
        }
    }
}