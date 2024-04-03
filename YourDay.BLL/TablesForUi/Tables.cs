namespace YourDay.BLL.TablesForUi
{
    public class Tables
    {
        public List<ColumnForTables> ManagerColumns { get; set; }

        public List<ColumnForTables> OrderColumns { get; set; }

        public List<ColumnForTables> TaskColumns { get; set; }

        public Tables()
        {
            ManagerColumns = new List<ColumnForTables>();
            OrderColumns = new List<ColumnForTables>();
            TaskColumns = new List<ColumnForTables>();
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


//    public void GetTableForStatistics()
//    {
//        Columns.AddRange(
//                new Column[]
//                {
//                    new Column()
//                {
//                    Field="IdManager",
//                    LayoutHeader="Идентификатор менеджера"
//                },
//                new Column()
//                {
//                    Field="NameManager",
//                    LayoutHeader="Имя менеджера"
//                },
//                new Column()
//                {
//                    Field="IdOrder",
//                    LayoutHeader="Идентификатор заказа"
//                },
//                new Column()
//                {
//                    Field="TitleOrder",
//                    LayoutHeader="Название заказа"
//                },
//                new Column()
//                {
//                    Field="IdTask",
//                    LayoutHeader="Идентификатор задачи"
//                },
//                new Column()
//                {
//                    Field="TitleTask",
//                    LayoutHeader="название задачи"
//                }
//                });
//    }
//}
//}


