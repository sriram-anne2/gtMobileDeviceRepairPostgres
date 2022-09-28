using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gtMobileDeviceRepairShop.Models;

public class Vehicles
{
    [Key, Required]
    public long VehicleId { get; set; }
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public long UserId { get; set; }
    
    [ForeignKey("UserId")]
    public User User { get; set; }
}