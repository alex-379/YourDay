namespace YourDay.BLL.Models.OrderModels.InputModels
{
    public class OrderInputModel
    {
        public string OrderName { get; set; }

        public int ClientId { get; set; }

        public int ManagerId { get; set; }

        public int StatusId { get; set; }

        public string Date { get; set; }

        public string Adress { get; set; }

        public int CountPeople { get; set; }

        public int Price { get; set; }

        public int Evaluation { get; set; }

        public string Comments { get; set; }

        public bool IsDeleted { get; set; }
    }
}
