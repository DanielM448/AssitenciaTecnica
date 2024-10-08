﻿using Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.VO
{
    public class ServiceOrderVO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EquipmentId { get; set; }
        public string ProblemDescription { get; set; } = string.Empty;
        public ServiceOrderStatus Status { get; set; }
        public DateTime Created {  get; set; }
        public List<PartVO> Parts { get; set; }
    }
}
