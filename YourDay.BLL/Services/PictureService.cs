using YourDay.BLL.IServices;

namespace YourDay.BLL.Services
{
    public class PictureService: IPictureService
    {
        private string _link;

        public string GetPictureNameByCounter(int count)
        {
            switch (count)
            {
                case 15:
                    _link = "/images/gallery/01.jpg";

                    break;
                case 10:
                    _link = "/images/gallery/02.jpg";

                    break;
                case 5:
                    _link = "/images/gallery/03.jpg";

                    break;
            }

            return _link;
        }
    }
}