using Enterprise_Server.Data;
using Enterprise_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/product")]
public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var product = await _context.Products.ToListAsync();
        return Ok(product);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null) { return NotFound(); }

        return Ok(product);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Product product)
    {
        //product.Id = new Guid();

        _context.Products.Add(product);
        _context.SaveChanges();

        return Ok("product created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Product productGet)
    {
        var product = _context.Products.FirstOrDefault(c => c.Id == productGet.Id);

        if (product == null)
        {
            return NotFound();
        }

        product.Name = productGet.Name;
        product.Price = productGet.Price;
        product.Weight = productGet.Weight;
        product.Id_Enterprise = productGet.Id_Enterprise;
      


        _context.SaveChanges();

        return Ok("Product updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Product productGet)
    {
        var product = _context.Products.FirstOrDefault(c => c.Id == productGet.Id);

        if (product == null) { return NotFound(); }

        _context.Products.Remove(product);
        _context.SaveChanges();

        return Ok("Product deleted");
    }
}
