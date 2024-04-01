using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace YourDay.BLL.Services
{
    public class EnumService:IEnumService
    {
        public string? GetDisplayName(Enum enumValue)
        {
            return enumValue
                      .GetType()
                      .GetMember(enumValue.ToString())
                      .First()?
                      .GetCustomAttribute<DisplayAttribute>()?
                      .Name;
        }
    }
}