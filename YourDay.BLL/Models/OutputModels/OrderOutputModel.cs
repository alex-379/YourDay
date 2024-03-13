namespace YourDay.BLL.Models.OutputModels
{
    public class OrderOutputModel
    {
        public int Id { get; set; }

        public string OrderName { get; set; }

        public string ClientName { get; set; }

        public string Date { get; set; }

        public int CountPeople { get; set; }

        public string Adress { get; set; }

        public string Comments { get; set; }
    }
}
