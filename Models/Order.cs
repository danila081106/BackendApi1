using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class Order
    {
        public Order()
        {
            Deliveries = new HashSet<Delivery>();
            OrderedProducts = new HashSet<OrderedProduct>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
