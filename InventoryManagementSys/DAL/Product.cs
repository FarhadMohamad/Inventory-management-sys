using System;
using System.Collections.Generic;

namespace InventoryManagementSys.DAL
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int? CategoryId { get; set; }
        public string Status { get; set; }

        public virtual Category Category { get; set; }
    }
}
