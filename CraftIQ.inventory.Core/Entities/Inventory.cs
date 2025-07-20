
namespace CraftIQ.inventory.Core.Entities
{
    public class Inventory : BaseEntity
    {

        //public Inventory() { } // for Entity FW


        //public Inventory(Guid InventoryId , Guid productId , Guid ProductId) { }
        public Guid InventoryId { get; set; }

        public string Name { get; set; }
        public Guid ProductId { get; set; } //referce to product

        public List<Product> products { get; set; } = new(); //refer to product  list

        public int Quantity { get; set; } //quantity of product in inventory

        public int ReorderLevel { get; set; }

        public string Location { get; set; } = string.Empty;

         public DateTimeOffset LastUpdated { get; set; } 

    }
}
