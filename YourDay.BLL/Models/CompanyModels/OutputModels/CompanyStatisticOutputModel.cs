namespace YourDay.BLL.Models.CompanyModels.OutputModels
{
    public class CompanyStatisticOutputModel
    {
        public int ManagerId {  get; set; }

        public string ManagerName { get; set; }

        public int OrderId {  get; set; }

        public string OrderTitle { get; set; }

        public int TaskId {  get; set; }

        public string TaskTitle { get; set; }

        public int ClientId {  get; set; }

        public string ClientName { get; set; }
    }
}