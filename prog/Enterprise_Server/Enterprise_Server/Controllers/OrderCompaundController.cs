using Enterprise_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Enterprise_Server.Data;


namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/order_compaund")]
public class OrderCompaundController : Controller
{
    private readonly AppDbContext _context;

    public OrderCompaundController(AppDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllOrderCompaund()
    {
        var compaunds = await _context.OrderCompaunds.ToListAsync();
        return Ok(compaunds);
    }




    [HttpGet("by_order/{id_order}")]
    public async Task<IActionResult>GetByIdOrders(Guid id_order)
    {
        var compaund = await _context.OrderCompaunds.Where(o => o.Id_Order == id_order).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }


    [HttpGet("by_product/{id_product}")]
    public async Task<IActionResult> GetByIdProducts(Guid id_product)
    {
        var compaund = await _context.OrderCompaunds.Where(o => o.Id_Product == id_product).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }



    [HttpPost]
    public async Task<IActionResult> Set([FromBody] OrderCompaund compaund)
    {

        _context.OrderCompaunds.Add(compaund);
        _context.SaveChanges();

        return Ok("Order Compaund created");
    }


    [HttpPut]
    public async Task<IActionResult> Put([FromBody] OrderCompaund compaundGet)
    {

        var compaund = _context.OrderCompaunds.FirstOrDefault(c => 
        c.Id_Order == compaundGet.Id_Order &&
        c.Id_Product == compaundGet.Id_Product);

        if (compaund == null)
        {
            return NotFound();
        }


        compaund.Quantity = compaundGet.Quantity;

        _context.SaveChanges();

        return Ok("Order Compaund updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] OrderCompaund compaundGet)
    {
        var compaund = _context.OrderCompaunds.FirstOrDefault(c =>
        c.Id_Order == compaundGet.Id_Order &&
        c.Id_Product == compaundGet.Id_Product);
        
        if (compaund == null) { return NotFound(); }

        _context.OrderCompaunds.Remove(compaund);
        _context.SaveChanges();

        return Ok("Order Compaund deleted");
    }

}
