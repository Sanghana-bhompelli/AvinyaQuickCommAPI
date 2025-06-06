﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DBLayer.Models
{
    public class EmployessModel
    {
        public int EmployeeId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? BirthDate { get; set; }
        public string? City { get; set; }
        public string? Photo { get; set; }
        public string? Notes { get; set; }
    }
}
