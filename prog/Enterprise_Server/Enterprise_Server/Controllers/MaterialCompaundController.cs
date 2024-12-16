using Microsoft.EntityFrameworkCore;
using Enterprise_Server.Data;
using Enterprise_Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise_Server.Controllers;

[ApiController]
[Route("api/material_compaund")]
public class MaterialCompaundController : Controller
{
    private readonly AppDbContext _context;

    public MaterialCompaundController(AppDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllMaterialsCompaund()
    {
        var compaunds = await _context.MaterialCompaunds.ToListAsync();
        return Ok(compaunds);
    }



    
    [HttpGet("by_product/{id_product}")]
    public async Task<IActionResult> GetByIdProduct(Guid id_product)
    {
        var compaund = await _context.MaterialCompaunds.Where(o => o.Id_Product == id_product).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }


    [HttpGet("by_material/{id_material}")]
    public async Task<IActionResult> GetByIdMaterial(Guid id_material)
    {
        var compaund = await _context.MaterialCompaunds.Where(o => o.Id_Material == id_material).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }

    

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] MaterialCompaund compaund)
    {

        _context.MaterialCompaunds.Add(compaund);
        _context.SaveChanges();

        return Ok("Material Compaund created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] MaterialCompaund compaundGet)
    {
        var compaund = _context.MaterialCompaunds.FirstOrDefault(c => 
        c.Id_Material == compaundGet.Id_Material &&
        c.Id_Product == compaundGet.Id_Product);

        if (compaund == null)
        {
            return NotFound();
        }


        compaund.Weight = compaundGet.Weight;


        _context.SaveChanges();

        return Ok("Material Compaund updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] MaterialCompaund compaundGet)
    {
        var compaund = _context.MaterialCompaunds.FirstOrDefault(c =>
        c.Id_Material == compaundGet.Id_Material &&
        c.Id_Product == compaundGet.Id_Product);

        if (compaund == null) { return NotFound(); }

        _context.MaterialCompaunds.Remove(compaund);
        _context.SaveChanges();

        return Ok("Material Compaund deleted");
    }

}
