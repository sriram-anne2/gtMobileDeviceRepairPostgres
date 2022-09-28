using System.ComponentModel.DataAnnotations;

namespace gtMobileDeviceRepairShop.Models;

public class Repair
{
    [Key, Required]
    public long RepairId { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public string TechnicianId { get; set; }
    
    
    [Required]
    public Customer Customer { get; set; }
    [Required]
    public Device Device { get; set; }
    [Required]
    public DailyOrderSession DailyOrderSession { get; set; }
}