using System.Collections;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.BLL.Test.TestCaseSources
{
    public class GetUserByIdTestCaseSourses : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData(1, new UserDto() { Id = 1, UserName = "Aлексей" }, "A");
        }
    }
}