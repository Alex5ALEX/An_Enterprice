using Enterprise_Server.Models;
using Enterprise_Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/enterprise")]
public class EnterpriseController : Controller
{
    private readonly AppDbContext _context;

    public EnterpriseController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllEnterprise()
    {
        var enterprise = await _context.Enterprises.ToListAsync();
        return Ok(enterprise);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var enterprise = await _context.Enterprises.FindAsync(id);

        if (enterprise == null) { return NotFound(); }

        return Ok(enterprise);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Enterprise enterprise)
    {
        enterprise.Id = new Guid();

        _context.Enterprises.Add(enterprise);
        _context.SaveChanges();

        return Ok("enterprise created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Enterprise enterpriseGet)
    {
        var enterprise = _context.Enterprises.FirstOrDefault(c => c.Id == enterpriseGet.Id);

        if (enterprise == null)
        {
            return NotFound();
        }


        enterprise.Company = enterpriseGet.Company;
        enterprise.ContactPerson = enterpriseGet.ContactPerson;
        enterprise.Phone = enterpriseGet.Phone;
        enterprise.Email = enterpriseGet.Email;
        enterprise.Address = enterpriseGet.Address;
        enterprise.Description = enterpriseGet.Description;

        _context.SaveChanges();

        return Ok("Enterprise updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Enterprise enterpriseGet)
    {
        var enterprise = _context.Enterprises.FirstOrDefault(c => c.Id == enterpriseGet.Id);

        if (enterprise == null) { return NotFound(); }

        _context.Enterprises.Remove(enterprise);
        _context.SaveChanges();

        return Ok("Enterprise deleted");
    }

}
