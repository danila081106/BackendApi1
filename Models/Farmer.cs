using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class Farmer
    {
        public Farmer()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? FarmInfo { get; set; }
        public string? ContactInfo { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
