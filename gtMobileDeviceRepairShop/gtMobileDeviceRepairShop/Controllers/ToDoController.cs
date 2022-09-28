using gtMobileDeviceRepairShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gtMobileDeviceRepairShop.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ToDoController : ControllerBase
{

    private readonly RepairShopDBContext _context;

    // injecting the context  
    public ToDoController(RepairShopDBContext context)
    {
        _context = context;

        if (_context.ToDoItems.Count() == 0)
        {
            _context.ToDoItems.Add(new ToDoItem { Name = "Coding with Amar" });
            _context.SaveChanges();
        }
        
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ToDoItem>>> GetAll()
    {
        return await _context.ToDoItems.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ToDoItem>> GetById(long id)
    {
        var todoItem = await _context.ToDoItems.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
    }

    [HttpPost]
    public async Task<ActionResult<ToDoItem>> SaveSingleToDoItem(ToDoItem toDoItem)
    {
        _context.ToDoItems.AddAsync(toDoItem);
        await _context.SaveChangesAsync();

        return Ok();
    }



}