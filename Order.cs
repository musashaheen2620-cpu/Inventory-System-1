using System;

namespace InventorySystem
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }  - // "Queued" or "Processed"
    }
}
