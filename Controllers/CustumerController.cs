using CustomerApi.Data;
using CustomerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    public CustomersController(ApplicationDbContext db) => _db = db;

    // GET: api/customers
    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _db.Customers.ToListAsync());

    // GET: api/customers/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var customer = await _db.Customers.FindAsync(id);
        return customer is null ? NotFound() : Ok(customer);
    }

    // POST: api/customers
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Customer customer)
    {
        _db.Customers.Add(customer);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = customer.CustomerID }, customer);
    }

    // PUT: api/customers/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Customer updated)
    {
        if (id != updated.CustomerID) 
            return BadRequest();

        _db.Entry(updated).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/customers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var customer = await _db.Customers.FindAsync(id);
        if (customer is null) return NotFound();

        _db.Customers.Remove(customer);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
