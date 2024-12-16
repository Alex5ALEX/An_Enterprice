using Enterprise_Server.Models;
using Enterprise_Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/order")]
public class OrderController : Controller
{
    private readonly AppDbContext _context;

    public OrderController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var order = await _context.Orders.ToListAsync();
        return Ok(order);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var order = await _context.Orders.FindAsync(id);

        if (order == null) { return NotFound(); }

        return Ok(order);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Order order)
    {
        //order.Id = new Guid();

        _context.Orders.Add(order);
        _context.SaveChanges();

        return Ok("order created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Order orderGet)
    {
        var order = _context.Orders.FirstOrDefault(c => c.Id == orderGet.Id);

        if (order == null)
        {
            return NotFound();
        }

        order.Date = orderGet.Date;
        order.Description = orderGet.Description;
        order.Id_Customer = orderGet.Id_Customer;



        _context.SaveChanges();

        return Ok("Order updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Order orderGet)
    {
        var order = _context.Orders.FirstOrDefault(c => c.Id == orderGet.Id);

        if (order == null) { return NotFound(); }

        _context.Orders.Remove(order);
        _context.SaveChanges();

        return Ok("Order deleted");
    }

}
