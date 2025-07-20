using System;
using System.Collections.Generic;

namespace CraftIQ.inventory.Core.Entities
{
    public class Product : BaseEntity
    {
        public Guid ProductId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }

        public int CategoryId { get; set; } 
        public decimal TaxCost { get; set; }
        public decimal ProfitPerUnit { get; set; }
        public decimal ProductionCost { get; set; }

        public Category Category { get; set; } = null!;
    }
}
