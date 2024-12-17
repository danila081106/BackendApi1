using System;
using System.Collections.Generic;

namespace BackendApi1.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int StockLevel { get; set; }
        public DateTime? RestockDate { get; set; }

        public virtual Product? Product { get; set; }
    }
}
