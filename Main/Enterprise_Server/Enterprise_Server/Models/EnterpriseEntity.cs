namespace Enterprise_Server.Models;

public class EnterpriseEntity
{
    public Guid Id { get; set; }

    public string Company { get; set; } = string.Empty;

    public string ContactPerson { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;


    public List<EmployeeEntity> Emplolyees { get; set; } = [];

    public List<ProductEntity> Products { get; set; } = [];
}