using gtMobileDeviceRepairShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gtMobileDeviceRepairShop.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    
    private readonly RepairShopDBContext _context;

    // injecting the context  
    public UserController(RepairShopDBContext context)
    {
        _context = context;

        if (_context.Users.Count() == 0)
        {
            _context.Users.Add(new User() { Name = "Sriram Anne", Location = "Atlanta, GA"});
            _context.SaveChanges();
        }
        
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }

    
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetById(long id)
    {
        var user = await _context.Users.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }

    [HttpPost]
    public async Task<ActionResult<User>> SaveSingleUser(User user)
    {
        _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return Ok();
    }


    


}