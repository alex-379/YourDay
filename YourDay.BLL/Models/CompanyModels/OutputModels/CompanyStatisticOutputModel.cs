namespace YourDay.BLL.Models.CompanyModels.OutputModels
{
    public class CompanyStatisticOutputModel
    {
        public int IdManager {  get; set; }
        public string NameManager { get; set; }
        public int IdOrder {  get; set; }
        public string TitleOrder { get; set; }
        public int IdTask {  get; set; }
        public string TitleTask { get; set; }
        public int ClientId {  get; set; }
        public string NameClient { get; set; }
    }
}
