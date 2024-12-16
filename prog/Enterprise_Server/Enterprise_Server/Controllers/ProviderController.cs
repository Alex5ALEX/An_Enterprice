using Enterprise_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Enterprise_Server.Data;


namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/provider")]
public class ProviderController : Controller
{
    private readonly AppDbContext _context;

    public ProviderController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProviders()
    {
        var providers = await _context.Providers.ToListAsync();
        return Ok(providers);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var provider = await _context.Providers.FindAsync(id);

        if (provider == null) { return NotFound(); }

        return Ok(provider);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Provider provider)
    {
        provider.Id = new Guid();

        _context.Providers.Add(provider);
        _context.SaveChanges();

        return Ok("provider created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Provider providerGet)
    {
        var provider = _context.Providers.FirstOrDefault(c => c.Id == providerGet.Id);

        if (provider == null)
        {
            return NotFound();
        }


        provider.Company = providerGet.Company;
        provider.ContactPerson = providerGet.ContactPerson;
        provider.Phone = providerGet.Phone;
        provider.Email = providerGet.Email;
        provider.Address = providerGet.Address;

        _context.SaveChanges();

        return Ok("Provider updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Provider providerGet)
    {
        var provider = _context.Providers.FirstOrDefault(c => c.Id == providerGet.Id);

        if (provider == null) { return NotFound(); }

        _context.Providers.Remove(provider);
        _context.SaveChanges();

        return Ok("Provider deleted");
    }
}
