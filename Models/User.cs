using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class User
    {
        public User()
        {
            DeliveryAddresses = new HashSet<DeliveryAddress>();
            Orders = new HashSet<Order>();
            ProductRatings = new HashSet<ProductRating>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string? DeliveryAddress { get; set; }

        public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
    }
}
