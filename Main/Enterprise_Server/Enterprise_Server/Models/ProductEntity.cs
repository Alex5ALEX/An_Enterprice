namespace Enterprise_Server.Models;

public class ProductEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; } = 0;

    public double Weight { get; set; } = 0;


    public Guid Id_Enterprise { get; set; }

    public EnterpriseEntity? Enterprise { get; set; }


    public List<OrderEntity> Order { get; set; } = [];


    public List<CompaundEntity> Compaund { get; set; } = [];
}
