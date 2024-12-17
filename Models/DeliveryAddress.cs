using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class DeliveryAddress
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Address { get; set; } = null!;

        public virtual User? User { get; set; }
    }
}
