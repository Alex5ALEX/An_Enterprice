namespace EnterpriseClient.Models;

public class SupplyCompaund
{
    public int Quantity { get; set; } = 0;

    //links

    public Guid Id_Material { get; set; }

    public Material? Material { get; set; }

    public Guid Id_Supply { get; set; }

    public Supply? Supply { get; set; }
}
