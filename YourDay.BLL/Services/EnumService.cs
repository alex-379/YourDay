using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace YourDay.BLL.Services
{
    public static class EnumService
    {
        public static string GetDisplayName(this Enum enumValue)
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