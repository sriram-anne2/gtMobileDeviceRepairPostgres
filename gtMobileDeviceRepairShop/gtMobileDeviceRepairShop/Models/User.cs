using System.ComponentModel.DataAnnotations;

namespace gtMobileDeviceRepairShop.Models;

public class User
{
    [Key, Required]
    public long UserId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    
    public ICollection<Vehicles> Vehicles { get; set; }
}