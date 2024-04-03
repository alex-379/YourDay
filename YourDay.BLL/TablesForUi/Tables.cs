namespace YourDay.BLL.TablesForUi
{
    public class Tables
    {
        public List<ColumnForTables> ManagerColumns { get; set; }

        public List<ColumnForTables> OrderColumns { get; set; }

        public List<ColumnForTables> TaskColumns { get; set; }

        public List<ColumnForTables> ContactWithManagerColumns {  get; set; }

        public Tables()
        {
            ManagerColumns = new List<ColumnForTables>();
            OrderColumns = new List<ColumnForTables>();
            TaskColumns = new List<ColumnForTables>();
            ContactWithManagerColumns= new List<ColumnForTables>();
        }

        public void GetTableForPrintContactWithManager()
        {
            ContactWithManagerColumns.AddRange(
                new ColumnForTables[]
                {
                    new ColumnForTables()
                    {
                        Field="Name",
                        LayoutHeader="Имя менеджера"
                    },
                     new ColumnForTables()
                    {
                        Field="Phone",
                        LayoutHeader="Номер телефона менеджера"
                    }
                });
        }

        public void GetTableForPrintManagers()
        {
            ManagerColumns.AddRange(
                new ColumnForTables[]
                {
                    new ColumnForTables()
                    {
                        Field="ManagerId",
                        LayoutHeader="Идентификатор менеджера"
                    },
                    new ColumnForTables()
                    {
                        Field="ManagerName",
                        LayoutHeader="Имя менеджера"
                    },
                });
        }

        public void GetTableForPrintOrders()
        {
            OrderColumns.AddRange(
                new ColumnForTables[]
                {
                    new ColumnForTables()
                    {
                        Field="OrderId",
                        LayoutHeader="Идентификатор заказа"
                    },
                    new ColumnForTables()
                    {
                        Field="OrderName",
                        LayoutHeader="Название заказа"
                    },
                });
        }

        public void GetTableForPrintTasks()
        {
            TaskColumns.AddRange(
                new ColumnForTables[]
                {
                    new ColumnForTables()
                    {
                        Field="OrderId",
                        LayoutHeader="Идентификатор заказа"
                    },
                    new ColumnForTables()
                    {
                        Field="TaskName",
                        LayoutHeader="Название задачи"
                    },
                });
        }
    }
}