using Enterprise_Server.Models;
using Enterprise_Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Enterprise_Server.Controllers;


[ApiController]
[Route("api/employee")]
public class EmployeeController : Controller
{
    private readonly AppDbContext _context;

    public EmployeeController(AppDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllEmployee()
    {
        var employee = await _context.Employees.ToListAsync();
        return Ok(employee);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var employee = await _context.Employees.FindAsync(id);

        if (employee == null) { return NotFound(); }

        return Ok(employee);

    }


    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Employee employee)
    {
        employee.Id = new Guid();

        _context.Employees.Add(employee);
        _context.SaveChanges();

        return Ok("Employee created");
    }




    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Employee employeeGet)
    {
        var employee = _context.Employees.FirstOrDefault(c => c.Id == employeeGet.Id);

        if (employee == null)
        {
            return NotFound();
        }


        employee.Name = employeeGet.Name;
        employee.Surname = employeeGet.Surname;
        employee.Jobtitle = employeeGet.Jobtitle;
        employee.Phone = employeeGet.Phone;
        employee.Email = employeeGet.Email;
        employee.Address = employeeGet.Address;

        _context.SaveChanges();

        return Ok("Employee updated");
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Employee employeeGet)
    {
        var employee = _context.Employees.FirstOrDefault(c => c.Id == employeeGet.Id);

        if (employee == null) { return NotFound(); }

        _context.Employees.Remove(employee);
        _context.SaveChanges();

        return Ok("Employee deleted");
    }
}
