namespace YourDay.BLL.TablesForUi
{
    public class ManagerRow
    {
        public int ManagerId { get; set; }

        public string? ManagerName { get; set; }

        public IEnumerable<OrderRow> TasksByOrder { get; set; }
        public int OrderQuantity { get; set; }
    }
}