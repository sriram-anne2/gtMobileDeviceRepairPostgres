using System.ComponentModel.DataAnnotations;

namespace gtMobileDeviceRepairShop.Models;

public class ToDoItem
{
    [Key,Required]
    public long ItemId { get; set; }
    [Required]
    public string Name { get; set; }

    public bool IsComplete { get; set; } = false;

}