﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.OrderModels.InputModels;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public List<UserInputModel>? Workers { get; set; }

        public OrderInputModel? Order { get; set; }

        public SpecializationIntputModel? Specialization { get; set; }

        public Status? Status { get; set; }
    }
}