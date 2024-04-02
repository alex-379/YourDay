﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDay.BLL.Models.SpecializationModels.OutputModels
{
    public class SpecializationIdNameOutputModel
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}