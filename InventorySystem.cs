using System.Collections.ObjectModel;

namespace InventorySystemA
{
    public class InventorySystem
    {
        public ObservableCollection<Order> QueuedOrders { get; set; }
        public ObservableCollection<Order> ProcessedOrders { get; set; }

        public InventorySystem()
        {
            QueuedOrders = new ObservableCollection<Order>();
            ProcessedOrders = new ObservableCollection<Order>();
        }

        public void AddOrder(Order order)
        {
            QueuedOrders.Add(order);
        }

        public void ProcessOrder()
        {
            if (QueuedOrders.Count > 0)
            {
                var order = QueuedOrders[0];
                QueuedOrders.RemoveAt(0);
                order.Status = "Processed";
                ProcessedOrders.Add(order);
            }
        }
    }
}
