namespace YourDay.Components.Pages
{
    public class ManagerRow
    {
        public int ManagerId { get; set; }
        public string? ManagerName { get; set; }
        public IEnumerable<IGrouping<int, TaskRow>> TasksByOrder { get; set; }
    }
    public class ManagerRowsColumn
    {
        public string Field { get; set;}
        public string LayoutHeader { get; set;}
    }
    public class OrderRow
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        
      
    }
    public class OrderRowColumn
    {
        public string Field { get; set; }
        public string LayoutHeader { get; set; }
    }
    public class TaskRow
    {
        public int ManagerId { get; set; }
        public int OrderId { get; set; }
        public  string TaskName { get; set; }
    }
    public class TaskRowColumn
    {
        public string Field { get; set; }
        public string LayoutHeader { get; set; }
    }

}
