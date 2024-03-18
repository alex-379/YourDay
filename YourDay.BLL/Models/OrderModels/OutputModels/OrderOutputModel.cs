namespace YourDay.BLL.Models.OrderModels.OutputModels
{
    public class OrderOutputModel
    {
        public int Id { get; set; }

        public string OrderName { get; set; }

        //public int Client { get; set; }

        //public int Manager { get; set; }

        //public int Status { get; set; }

        public DateTime Date { get; set; }

        public string Adress { get; set; }

        public int CountPeople { get; set; }

        public int Price { get; set; }


    }
}
