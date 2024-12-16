using Enterprise_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Enterprise_Server.Data;

namespace Enterprise_Server.Controllers;



[ApiController]
[Route("api/supply")]
public class SupplyController : Controller
{
    private readonly AppDbContext _context;

    public SupplyController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllSupplies()
    {
        var supplys = await _context.Supplies.ToListAsync();
        return Ok(supplys);
    }




    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var supply = await _context.Supplies.FindAsync(id);

        if (supply == null) { return NotFound(); }

        return Ok(supply);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Supply supply)
    {

        _context.Supplies.Add(supply);
        _context.SaveChanges();

        return Ok("Supply created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Supply supplyGet)
    {
        var supply = _context.Supplies.FirstOrDefault(c => c.Id == supplyGet.Id);

        if (supply == null)
        {
            return NotFound();
        }


        supply.Date = supplyGet.Date;
        supply.Description = supplyGet.Description;
        supply.Id_Provider = supplyGet.Id_Provider;

        _context.SaveChanges();

        return Ok("Supply updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Supply supplyGet)
    {
        var supply = _context.Supplies.FirstOrDefault(c => c.Id == supplyGet.Id);

        if (supply == null) { return NotFound(); }

        _context.Supplies.Remove(supply);
        _context.SaveChanges();

        return Ok("Supply deleted");
    }
}
