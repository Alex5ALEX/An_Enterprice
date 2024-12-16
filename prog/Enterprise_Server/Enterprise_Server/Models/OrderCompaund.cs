namespace Enterprise_Server.Models;

public class OrderCompaund
{
    public int Quantity { get; set; } = 0;

    //links

    public Guid Id_Order { get; set; }

    public Order? Order { get; set; }

    public Guid Id_Product { get; set; }

    public Product? Product { get; set; }
}
