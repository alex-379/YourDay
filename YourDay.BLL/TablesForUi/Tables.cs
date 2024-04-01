namespace YourDay.BLL.Tables
{
    public class Tables
    {
        public List<Column> Columns { get; set; }

        public Tables()
        {
            Columns = new List<Column>();
        }

        public void GetTableForPrintManagers()
        {
            Columns.AddRange(
                new Column[]
                {
                new Column()
                {
                    Field="Name",
                    LayoutHeader="Имя"
                },
                new Column()
                {
                    Field="Phone",
                    LayoutHeader="Телефон"
                }
        });
        }
    }
}