using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.IServices
{
    public interface IEnumService
    {
        public string? GetDisplayName(Enum enumValue);
    }
}