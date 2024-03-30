namespace YourDay.BLL.Models.CompanyModels.OutputModels
{
    public class CompanyStatisticOutputModel
    {
        public int IdManager {  get; set; }
        public int IdOrder {  get; set; }
        public int IdTask {  get; set; }
        public string NameManager { get; set; }

        public string TitleOrder { get; set; }

        public string TitleTask { get; set; }
    }
}
