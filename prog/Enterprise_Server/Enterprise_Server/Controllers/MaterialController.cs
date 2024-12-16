using Enterprise_Server.Models;
using Enterprise_Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/material")]
public class MaterialController : Controller
{
    private readonly AppDbContext _context;

    public MaterialController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllMaterials()
    {
        var materials = await _context.Materials.ToListAsync();
        return Ok(materials);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var material = await _context.Materials.FindAsync(id);

        if (material == null) { return NotFound(); }

        return Ok(material);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Material material)
    {
        material.Id = new Guid();

        _context.Materials.Add(material);
        _context.SaveChanges();

        return Ok("material created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Material materialGet)
    {
        var material = _context.Materials.FirstOrDefault(c => c.Id == materialGet.Id);

        if (material == null)
        {
            return NotFound();
        }

        material.Name = materialGet.Name;
        material.Type = materialGet.Type;
        material.Description = materialGet.Description;


        _context.SaveChanges();

        return Ok("Material updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Material materialGet)
    {
        var material = _context.Materials.FirstOrDefault(c => c.Id == materialGet.Id);

        if (material == null) { return NotFound(); }

        _context.Materials.Remove(material);
        _context.SaveChanges();

        return Ok("Material deleted");
    }


}
