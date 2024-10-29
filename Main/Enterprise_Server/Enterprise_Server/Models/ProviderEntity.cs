namespace Enterprise_Server.Models;

public class ProviderEntity
{
    public Guid Id { get; set; }

    public string Company { get; set; } = string.Empty;

    public string ContactPerson { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;


    public List<PurcasedMaterialEntity> PurcasedMaterials { get; set; } = [];
}
