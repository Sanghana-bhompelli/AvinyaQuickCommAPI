﻿using System;
using System.Collections.Generic;

namespace Entity.DBLayer.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public string? OrderDate { get; set; }

    public int? ShipperId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employess? Employee { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Shipper? Shipper { get; set; }
}
