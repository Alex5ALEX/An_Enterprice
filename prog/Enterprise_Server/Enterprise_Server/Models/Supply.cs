namespace Enterprise_Server.Models;

public class Supply
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public string Description { get; set; } = string.Empty;


    //links

    public List<SupplyCompaund> SupplyCompaunds { get; set; } = [];

    public Guid Id_Provider { get; set; }   

    public Provider? Provider { get; set; }
}