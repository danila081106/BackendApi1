using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class Delivery
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string? DeliveredBy { get; set; }
        public bool? Status { get; set; }

        public virtual Order? Order { get; set; }
    }
}
