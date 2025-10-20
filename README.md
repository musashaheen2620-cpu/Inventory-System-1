Order.cs:

- Denne fil definere en klasse, som beskriver en ordre I invetory system
- Det er et eksempel på en ordre når en kunde angiver hvad kunden vil have:

"namespace InventorySystem" - dette er en mappe

"public class Order" - denne kode definere ordren

"public int OrderId { get; set; }" - Her defineres ordrenummeret, fx. orderId:7725

"public string ProductName { get; set; }" - Her defineres produktets navn, fx. "Kasse"

"public int Quantity { get; set; }" - Her vises hvormange ordre, der er bestilt, om det er 1 eller flere Item(s)

"public string Status { get; set; }" - Dette viser hvor ordren befinder sig
Herunder kan der være "Queued" som betyder at ordren stadig venter på at blive behandlet og "Processed" betyder at ordren er færdigbehandlet

