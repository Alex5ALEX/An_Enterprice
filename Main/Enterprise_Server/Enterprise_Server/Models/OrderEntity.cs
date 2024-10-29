namespace Enterprise_Server.Models;

public class OrderEntity
{

    public Guid Id { get; set; }

    public int Quantity { get; set; } = 0;

    public DateTime Data {  get; set; } = DateTime.MinValue;


    public Guid Id_Customer { get; set; }

    public CustomerEntity? Customer { get; set; }

    public Guid Id_Product { get; set; }

    public ProductEntity? Product { get; set; }
}
