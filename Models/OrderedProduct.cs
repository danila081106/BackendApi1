﻿using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class OrderedProduct
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
