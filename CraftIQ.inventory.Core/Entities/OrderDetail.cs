using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.inventory.Core.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid _OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public int OrderId { get; set; } 
        public Order Order { get; set; } = new();

        public int ProductId { get; set; } // FK to Product.Id (int)
        public Product Product { get; set; } = null!;
    }
}
