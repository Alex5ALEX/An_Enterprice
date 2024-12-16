using Enterprise_Server.Models;
using Enterprise_Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_Server.Controllers;




[ApiController]
[Route("api/customer")]
public class CustomerController : Controller
{
    private readonly AppDbContext _context;

    public CustomerController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var сustomers = await _context.Customers.ToListAsync();
        return Ok(сustomers);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);

        if (customer == null) { return NotFound(); }

        return Ok(customer);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Customer customer)
    {
        customer.Id = new Guid();

        _context.Customers.Add(customer);
        _context.SaveChanges();

        return Ok("Customer created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Customer customerGet)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == customerGet.Id);

        if (customer == null)
        {
            return NotFound();
        }


        customer.Name = customerGet.Name;
        customer.Surname = customerGet.Surname;
        customer.Phone = customerGet.Phone;
        customer.Email = customerGet.Email;
        customer.Address = customerGet.Address;

        _context.SaveChanges();

        return Ok("Customer updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Customer customerGet)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == customerGet.Id);

        if (customer == null) { return NotFound(); }

        _context.Customers.Remove(customer);
        _context.SaveChanges();

        return Ok("Customer deleted");
    }
}
