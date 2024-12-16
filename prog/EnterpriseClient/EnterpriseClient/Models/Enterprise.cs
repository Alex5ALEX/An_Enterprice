namespace EnterpriseClient.Models;

public class Enterprise
{
    public Guid Id { get; set; }

    public string Company { get; set; } = string.Empty;

    public string ContactPerson { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;


    //links

    public List<Product> Products { get; set; } = [];

    public List<Employee> Employees { get; set; } = [];
}
