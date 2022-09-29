using Microsoft.EntityFrameworkCore;

namespace gtMobileDeviceRepairShop.Models;

public class RepairShopDBContext : DbContext
{
    public RepairShopDBContext(DbContextOptions<RepairShopDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<ToDoItem> ToDoItems { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Vehicles> Vehicles { get; set; }
    public DbSet<Parts> Parts { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<InventoryFullView> InventoryFullView { get; set; }
    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<Repair> Repairs { get; set; }
    public DbSet<DailyOrderSession> DailyOrderSessions { get; set; }

}