﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.Models.InputModels
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
