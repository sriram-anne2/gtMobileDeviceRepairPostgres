using System.ComponentModel.DataAnnotations;

namespace gtMobileDeviceRepairShop.Models;

public class DailyOrderSession
{
    [Key, Required]
    public long DailyOrderSessionId { get; set; }
    [Required]
    public string OpenedBy { get; set; }
    [Required]
    public DateTime OpenedAt { get; set; }
    [Required]
    public string ClosedBy { get; set; }
    [Required]
    public DateTime ClosedAt { get; set; }
    [Required]
    public bool IsActive { get; set; }
    
    [Required]
    public ICollection<Repair> Repairs { get; set; }

}