namespace EnterpriseClient.Models;

public class Order
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public string Description { get; set; } = string.Empty;

    //links

    public Guid Id_Customer { get; set; }

    public Customer? Customer { get; set; }

    public List<OrderCompaund> OrderCompaunds { get; set; } = [];

}
