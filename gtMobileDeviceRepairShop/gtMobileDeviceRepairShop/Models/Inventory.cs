using System.ComponentModel.DataAnnotations.Schema;

namespace gtMobileDeviceRepairShop.Models;

[Table("inventory_entry")]
public class Inventory
{
    public long Id { get; set; }

    public virtual Parts Parts { get; set; }
    public Int32 Quantity { get; set; }

}

[Table("inventory_full")]
public class InventoryFullView : Inventory
{
    public long Id { get; set; }
    public Parts Part { get; set; }
    public Int32 Quantity { get; set; }

}
