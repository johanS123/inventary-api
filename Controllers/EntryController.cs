using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalApiEfCore.Data;
using MinimalApiEfCore.Models;

namespace MinimalApiEfCore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EntryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EntryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Entry>>> GetEntries()
    {
        var entries = await _context.Entries
            .Include(e => e.Product)
            .ToListAsync();

        return Ok(entries);
    }

    [HttpPost]
    public async Task<ActionResult<Entry>> CreateEntry(Entry entry)
    {
        _context.Entries.Add(entry);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEntries), new { id = entry.Id }, entry);
    }
}
