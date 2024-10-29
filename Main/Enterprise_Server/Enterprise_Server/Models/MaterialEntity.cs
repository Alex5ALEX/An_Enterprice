namespace Enterprise_Server.Models;

public class MaterialEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; } = 0;

    public string Quantity { get; set; } = string.Empty;


    public List<PurcasedMaterialEntity> PurcasedMaterials { get; set; } = [];

    public List<CompaundEntity> Compaunds { get; set; } = [];

}