using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class ProductRating
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? Rating { get; set; }
        public string? Review { get; set; }

        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}
