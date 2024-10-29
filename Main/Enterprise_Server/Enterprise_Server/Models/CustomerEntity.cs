namespace Enterprise_Server.Models;

public class CustomerEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public List<OrderEntity> Orders { get; set; } = [];

}

