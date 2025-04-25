﻿using System.ComponentModel.DataAnnotations;

namespace PortfolioCore.Entities
{
    public class Service
    {
        [Key]
        public int ServicesID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceIcon { get; set; }
        public string ServiceDescription { get; set; }
    }
}
