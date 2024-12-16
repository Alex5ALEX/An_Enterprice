namespace Enterprise_Server.Models;

public class Material
{
    public Guid Id { get; set; }

    public string Name {  get; set; } = string.Empty;
    
    public string Type {  get; set; } = string.Empty;

    public string Description {  get; set; } = string.Empty;

    //links

    public List<MaterialCompaund> MaterialCompaunds { get; set; } = [];

    public List<SupplyCompaund> SupplyCompaunds { get; set; } = [];

}