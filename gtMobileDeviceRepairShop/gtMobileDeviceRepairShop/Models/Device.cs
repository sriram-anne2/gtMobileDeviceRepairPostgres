using System.ComponentModel.DataAnnotations;

namespace gtMobileDeviceRepairShop.Models;

public class Device
{
    /*
     *     deviceId serial PRIMARY KEY,
    deviceType VARCHAR (15) NOT NULL,
    deviceOperatingSystem VARCHAR (15) NOT NULL,
    customerId INT NOT NULL,

     */
    [Key, Required]
    public long DeviceId { get; set; }
    [Required]
    public string deviceType { get; set; }
    [Required]
    public string deviceOperatingSystem { get; set; }
    
    [Required]
    public Customer Customer { get; set; }
    
    [Required]
    public ICollection<Repair> Repairs { get; set; }

}