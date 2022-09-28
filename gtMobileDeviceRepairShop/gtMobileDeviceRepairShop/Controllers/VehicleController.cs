using gtMobileDeviceRepairShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gtMobileDeviceRepairShop.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehicleController : ControllerBase
{
    private readonly RepairShopDBContext _context;

    // injecting the context  
    public VehicleController(RepairShopDBContext context)
    {
        _context = context;

        if (_context.Vehicles.Count() == 0)
        {
            _context.Vehicles.Add(new Vehicles() { Make = "Audi", Model = "RS5", Year = 2021, UserId = 1});
            _context.SaveChanges();
        }
        
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Vehicles>>> GetAll()
    {
        return await _context.Vehicles.ToListAsync();
    }
    
    [HttpPost]
    public async Task<ActionResult<Vehicles>> SaveSingleVehicle(Vehicles vehicle)
    {
        _context.Vehicles.AddAsync(vehicle);
        await _context.SaveChangesAsync();

        return Ok();
    }


    
}