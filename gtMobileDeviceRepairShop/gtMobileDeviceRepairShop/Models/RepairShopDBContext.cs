using Microsoft.EntityFrameworkCore;

namespace gtMobileDeviceRepairShop.Models;

public class RepairShopDBContext : DbContext
{
    public RepairShopDBContext(DbContextOptions<RepairShopDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Device> Devices { get; set; }
}