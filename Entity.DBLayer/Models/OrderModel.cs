﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DBLayer.Models
{
    public class OrderModel
    {

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public  string? OrderDate { get; set; }
        public int? ShipperID { get; set; }
        
    }
}
