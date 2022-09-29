using System.ComponentModel.DataAnnotations.Schema;

namespace gtMobileDeviceRepairShop.Models;

[Table("partdirectory")]
public class Parts
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

}