using Enterprise_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Enterprise_Server.Data;

namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/supply_compaund")]
public class SupplyCompaundController : Controller
{
    private readonly AppDbContext _context;

    public SupplyCompaundController(AppDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllSupplyCompaund()
    {
        var compaunds = await _context.SupplyCompaunds.ToListAsync();
        return Ok(compaunds);
    }




    [HttpGet("by_supply/{id_supply}")]
    public async Task<IActionResult> GetByIdSupply(Guid id_supply)
    {
        var compaund = await _context.SupplyCompaunds.Where(o => o.Id_Supply == id_supply).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }


    [HttpGet("by_material/{id_material}")]
    public async Task<IActionResult> GetByIdMaterial(Guid id_material)
    {
        var compaund = await _context.SupplyCompaunds.Where(o => o.Id_Material == id_material).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }



    [HttpPost]
    public async Task<IActionResult> Set([FromBody] SupplyCompaund compaund)
    {

        _context.SupplyCompaunds.Add(compaund);
        _context.SaveChanges();

        return Ok("Supply Compaund created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] SupplyCompaund compaundGet)
    {
        var compaund = _context.SupplyCompaunds.FirstOrDefault(c =>
        c.Id_Supply == compaundGet.Id_Supply &&
        c.Id_Material == compaundGet.Id_Material);

        if (compaund == null)
        {
            return NotFound();
        }


        compaund.Quantity = compaundGet.Quantity;


        _context.SaveChanges();

        return Ok("Supply Compaund updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] SupplyCompaund compaundGet)
    {
        var compaund = _context.SupplyCompaunds.FirstOrDefault(c =>
        c.Id_Supply == compaundGet.Id_Supply &&
        c.Id_Material == compaundGet.Id_Material);

        if (compaund == null) { return NotFound(); }

        _context.SupplyCompaunds.Remove(compaund);
        _context.SaveChanges();

        return Ok("Supply Compaund deleted");
    }
}
