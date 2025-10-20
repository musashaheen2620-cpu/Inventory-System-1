"Order.cs file"
- Denne fil definere en klasse, som beskriver en ordre I invetory system
- Det er et eksempel på en ordre når en kunde angiver hvad kunden vil have:


"namespace InventorySystem" - dette er en mappe
"public class Order" - denne kode definere ordren
"public int OrderId { get; set; }" - Her defineres ordrenummeret, fx. orderId:7725
"public string ProductName { get; set; }" - Her defineres produktets navn, fx. "Kasse"
"public int Quantity { get; set; }" - Her vises hvormange ordre, der er bestilt, om det er 1 eller flere Item(s)
"public string Status { get; set; }" - Dette viser hvor ordren befinder sig
Herunder kan der være "Queued" som betyder at ordren stadig venter på at blive behandlet og "Processed" betyder at ordren er færdigbehandlet

Der er også blevet brugt "int" og "string"
Int: bruges til heltal, fx. orderId, Quantity
string: bruges til tekst, fx. Productname, status



"InventorySystem.cs file"
- Denne fil styrer inventorysystem (lagerstyrringen)
- Der vises hvilken ordre der venter på at blive behandlet (Queued) og hvilken ordre der er blevet behandlet (processed)

"public ObservableCollection<Order> QueuedOrders { get; set; }
public ObservableCollection<Order> ProcessedOrders { get; set; }" - Disse to linjer laver to lister. 
- QueuedOrders: det er ordre der venter
- ProcessedOrders: det er ordre derer behandlet

"ObservableCollection" denne kode sikre at tabellen automatisk bliver opdateret når der tilføjes eller fjernes ordre. 

"public InventorySystem()
{
    QueuedOrders = new ObservableCollection<Order>();
    ProcessedOrders = new ObservableCollection<Order>();
}" - Når man laver et nyt inventory system, så bliver begge lister tomme, så de er klar til nye ordre


"public void AddOrder(Order order)
{
    QueuedOrders.Add(order);
}" - Her bruges denne kode til at tilføje en ny ordre (dvs ordre som venter på at blive behandlet)


"public void ProcessOrder()
{
    if (QueuedOrders.Count > 0)
    {
        var order = QueuedOrders[0];
        QueuedOrders.RemoveAt(0);
        order.Status = "Processed";
        ProcessedOrders.Add(order);
    }
}"
- Her flyttes en ordre fra "Queued" til "processed"


