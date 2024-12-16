namespace Enterprise_Server.Models;

public class Employee
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Jobtitle { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;


    //links 
    public Guid Id_Enterprise { get; set; }

    public Enterprise? Enterprise { get; set; }
}