using YourDay.BLL.Enums;
using YourDay.BLL.IServices;

namespace YourDay.BLL.Services
{
    public class StatusService : IStatusService
    {
        private string? _statusName;

        IEnumService _enumService;

        public StatusService()
        {
            _enumService = new EnumService();
        }

        public string GetStatusNameByIndex(int index)
        {
            switch (index)
            {
                case 0:
                    _statusName = _enumService.GetDisplayName(StatusUI.Received);

                    break;
                case 1:
                    _statusName = _enumService.GetDisplayName(StatusUI.InProgress);

                    break;
                case 2:
                    _statusName = _enumService.GetDisplayName(StatusUI.Completed);

                    break;
                case 3:
                    _statusName = _enumService.GetDisplayName(StatusUI.Canselled);

                    break;
            }

            return _statusName;
        }
    }
}