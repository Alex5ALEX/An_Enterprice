namespace Enterprise_Server.Models;


public class EmployeeEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string JobTitle { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;


    public Guid Id_Enterprise { get; set; }

    public EnterpriseEntity? Enterprise { get; set; }
}
