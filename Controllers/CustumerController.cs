using Microsoft.AspNetCore.Mvc;
using CustomerApi.Data;
using CustomerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CustomersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var customers = await _context.Customers.ToListAsync();
        return Ok(customers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        return customer == null ? NotFound() : Ok(customer);
    }
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Customer customer)
    {
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }
    _context.Customers.Add(customer);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(Get), new { id = customer.CustomerID }, customer);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Customer updatedCustomer)
    {
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    var customer = await _context.Customers.FindAsync(id);
    if (customer == null) return NotFound();

    customer.CustomerName = updatedCustomer.CustomerName;
    customer.PhoneNumber = updatedCustomer.PhoneNumber;
    customer.FaxNumber = updatedCustomer.FaxNumber;
    customer.DeliveryAddressLine1 = updatedCustomer.DeliveryAddressLine1;
    customer.CityName = updatedCustomer.CityName;

    await _context.SaveChangesAsync();
    return NoContent();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null) return NotFound();

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
