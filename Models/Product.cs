using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class Product
    {
        public Product()
        {
            Inventories = new HashSet<Inventory>();
            OrderedProducts = new HashSet<OrderedProduct>();
            ProductRatings = new HashSet<ProductRating>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int? FarmerId { get; set; }

        public virtual Farmer? Farmer { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
    }
}
