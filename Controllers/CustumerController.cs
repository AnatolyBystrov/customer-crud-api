using Microsoft.AspNetCore.Mvc;
using CustomerApi.Data;
using CustomerApi.Models;
using Microsoft.EntityFrameworkCore;
using CustomerApi.Responses;

namespace CustomerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CustomersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await _context.Customers.ToListAsync();
        return Ok(new SuccessResponse<List<Customer>>(customers));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomer(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
            return NotFound(new ErrorResponse($"Customer with ID {id} not found.", HttpContext.Request.Path));

        return Ok(new SuccessResponse<Customer>(customer));
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest(new ErrorResponse("Name parameter is required.", HttpContext.Request.Path));
        }

        var customers = await _context.Customers
            .Where(c => EF.Functions.ILike(c.CustomerName, $"%{name}%"))
            .ToListAsync();

        return Ok(new SuccessResponse<List<Customer>>(customers));
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ErrorResponse("Invalid customer data.", HttpContext.Request.Path));

        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerID }, new SuccessResponse<Customer>(customer));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(int id, [FromBody] Customer updatedCustomer)
    {
        if (id != updatedCustomer.CustomerID)
            return BadRequest(new ErrorResponse("ID mismatch.", HttpContext.Request.Path));

        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
            return NotFound(new ErrorResponse($"Customer with ID {id} not found.", HttpContext.Request.Path));

        customer.CustomerName = updatedCustomer.CustomerName;
        customer.PhoneNumber = updatedCustomer.PhoneNumber;
        customer.FaxNumber = updatedCustomer.FaxNumber;
        customer.DeliveryAddressLine1 = updatedCustomer.DeliveryAddressLine1;
        customer.CityName = updatedCustomer.CityName;

        await _context.SaveChangesAsync();
        return Ok(new SuccessResponse<Customer>(customer));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
            return NotFound(new ErrorResponse($"Customer with ID {id} not found.", HttpContext.Request.Path));

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();

        return Ok(new SuccessResponse<string>($"Customer with ID {id} deleted successfully."));
    }
}
