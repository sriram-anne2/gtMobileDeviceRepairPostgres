using System.ComponentModel.DataAnnotations;

namespace gtMobileDeviceRepairShop.Models;

public class Customer
{
    [Key, Required]
    public long CustomerId { get; set; }
    [Required]
    public string CustomerName { get; set; }
    [Required]
    public string CustomerEmail { get; set; }
    [Required]
    public string CustomerPhone { get; set; }
    [Required]
    public DateTime CreatedOn { get; set; }
    [Required]
    public DateTime LastUpdated { get; set; }
}