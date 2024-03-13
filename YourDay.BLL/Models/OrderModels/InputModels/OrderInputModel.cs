namespace YourDay.BLL.Models.OrderModels.InputModels
{
    public class OrderInputModel
    {
        public string OrderName { get; set; }

        public string ClientName { get; set; }

        public string Date { get; set; }

        public int CountPeople { get; set; }

        public string Adress { get; set; }

        public string Comments { get; set; }
    }
}
