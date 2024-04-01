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

        public void GetTableForStatistics()
        {
            Columns.AddRange(
                    new Column[]
                    {
                    new Column()
                {
                    Field="IdManager",
                    LayoutHeader="Индификатор менеджера"
                },
                new Column()
                {
                    Field="NameManager",
                    LayoutHeader="Имя менеджера"
                },
                new Column()
                {
                    Field="IdOrder",
                    LayoutHeader="Индификатор заказа"
                },
                new Column()
                {
                    Field="TitleOrder",
                    LayoutHeader="Название заказа"
                },
                new Column()
                {
                    Field="IdTask",
                    LayoutHeader="Индификатор задачи"
                },
                new Column()
                {
                    Field="TitleTask",
                    LayoutHeader="название задачи"
                }
                    });
        }
    }
}