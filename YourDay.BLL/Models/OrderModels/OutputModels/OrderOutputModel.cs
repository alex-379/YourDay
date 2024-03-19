namespace YourDay.BLL.Models.OrderModels.OutputModels
{
    public class OrderOutputModel
    {
        public int Id { get; set; }

        public string OrderName { get; set; }

        public int? ClientId { get; set; }

        public int? ManagerId { get; set; }

        //public int Status { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public int CountPeople { get; set; }

        public int Price { get; set; }


    }
}
