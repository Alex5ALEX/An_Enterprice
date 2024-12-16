namespace EnterpriseClient.Models;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; } = 0;

    public double Weight { get; set; } = 0;


    //links

    public List<OrderCompaund> OrderCompaunds { get; set; } = [];

    public Guid Id_Enterprise {  get; set; }

    public Enterprise? Enterprise { get; set; }

    public List<MaterialCompaund> MaterialCompaunds { get; set; } = []; 
}